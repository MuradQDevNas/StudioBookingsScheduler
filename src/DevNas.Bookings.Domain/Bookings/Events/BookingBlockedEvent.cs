using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace DevNas.Bookings.Bookings.Events
{
    [EventName("BookingBlocked")]
    public class BookingBlockedEvent : EntityEventData<Booking>
    {
        public BookingBlockedEvent(Booking entity) : base(entity)
        {
        }
    }
}
