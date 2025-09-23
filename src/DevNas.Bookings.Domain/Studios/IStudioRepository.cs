using System;
using Volo.Abp.Domain.Repositories;

namespace DevNas.Bookings.Studios
{
    public interface IStudioRepository : IRepository<Studio, Guid>
    {
    }
}
