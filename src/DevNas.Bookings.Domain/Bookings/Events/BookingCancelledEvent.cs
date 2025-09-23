using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace DevNas.Bookings.Bookings.Events
{
    [EventName("BookingCancelled")]
    public class BookingCancelledEvent : EntityEventData<Booking>
    {
        public BookingCancelledEvent(Booking entity) : base(entity)
        {
        }
    }
}
