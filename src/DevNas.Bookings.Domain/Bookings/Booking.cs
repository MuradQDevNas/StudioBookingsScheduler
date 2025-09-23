using DevNas.Bookings.Bookings.Events;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace DevNas.Bookings.Bookings
{
    public class Booking : FullAuditedAggregateRoot<Guid>
    {
        public Guid StudioId { get; protected set; }
        public Guid TeacherId { get; protected set; }
        public TimeRange TimeRange { get; protected set; }
        public BookingStatus Status { get; protected set; }

        protected Booking() { }

        public Booking(Guid id, Guid studioId, Guid teacherId, TimeRange timeRange)
            : base(id)
        {
            StudioId = studioId;
            TeacherId = teacherId;
            TimeRange = timeRange;
            Status = BookingStatus.Pending;
        }

        public void Confirm()
        {
            if (Status == BookingStatus.Pending)
            {
                Status = BookingStatus.Confirmed;
                this.AddDistributedEvent(new BookingCreatedEvent(this));
            }
            else
            {
                throw new BusinessException("Booking can only be confirmed from Pending state.");
            }
        }

        public void Cancel()
        {
            if (Status == BookingStatus.Cancelled)
            {
                throw new BusinessException("Booking is already cancelled.");
            }

            Status = BookingStatus.Cancelled;
            this.AddDistributedEvent(new BookingCancelledEvent(this));
        }

        public void BlockByAdmin()
        {
            Status = BookingStatus.Blocked;
            this.AddDistributedEvent(new BookingBlockedEvent(this));
        }

    }
}
