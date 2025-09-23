using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace DevNas.Bookings.Studios
{
    public class Studio : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; protected set; }
        public string Location { get; protected set; }
        public int Capacity { get; protected set; }
        public string Description { get; protected set; }

        protected Studio() { }

        public Studio(Guid id, string name, string location, int capacity, string description)
            : base(id)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Description = description;
        }

        public void UpdateDetails(string name, string location, int capacity, string description)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Description = description;
        }
    }
}
