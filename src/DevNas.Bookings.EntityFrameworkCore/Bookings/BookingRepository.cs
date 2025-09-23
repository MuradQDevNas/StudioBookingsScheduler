using DevNas.Bookings.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DevNas.Bookings.Bookings
{
    public class BookingRepository : EfCoreRepository<BookingsDbContext, Booking, Guid>, IBookingRepository

    {
        public BookingRepository(IDbContextProvider<BookingsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<bool> ExistsOverlapAsync(Guid studioId, TimeRange timeRange)
        {
            var dbSet = await GetDbSetAsync();

            return await dbSet.AnyAsync(x =>
                x.StudioId == studioId &&
                x.Status == BookingStatus.Confirmed &&
                x.TimeRange.StartTime < timeRange.EndTime &&
                x.TimeRange.EndTime > timeRange.StartTime
                );
        }
    }
}
