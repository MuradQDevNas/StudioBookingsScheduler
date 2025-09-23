using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DevNas.Bookings.Bookings
{
    public interface IBookingRepository : IRepository<Booking, Guid>
    {
        /// <summary>
        /// Check if a booking exists that overlaps with the given time range for a studio.
        /// </summary>
        Task<bool> ExistsOverlapAsync(Guid studioId, TimeRange timeRange);
    }
}
