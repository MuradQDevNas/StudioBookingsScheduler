using DevNas.Bookings.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DevNas.Bookings.Studios
{
    public class StudioRepository : EfCoreRepository<BookingsDbContext, Studio, Guid>, IStudioRepository
    {
        public StudioRepository(IDbContextProvider<BookingsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
