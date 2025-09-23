using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace DevNas.Bookings.Bookings.Events
{
    [EventName("BookingCreated")]
    public class BookingCreatedEvent : EntityEventData<Booking>
    {
        public BookingCreatedEvent(Booking entity) : base(entity)
        {
        }
    }
}
