using Volo.Abp.Domain.Services;

namespace DevNas.Bookings.Studios
{
    public class StudioManager : DomainService
    {
        public Studio Create(string name, string location, int capacity, string description)
        {
            return new Studio(GuidGenerator.Create(), name, location, capacity, description);
        }
    }
}
