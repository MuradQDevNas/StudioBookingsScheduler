using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;

namespace DevNas.Bookings.Bookings.Events.Handler
{
    public class BookingEventHandler :
    ILocalEventHandler<BookingCreatedEvent>,
    ILocalEventHandler<BookingCancelledEvent>,
    ILocalEventHandler<BookingBlockedEvent>,
    ITransientDependency
    {
        public Task HandleEventAsync(BookingCreatedEvent eventData)
        {
            // TODO: Send notification (email/SMS/SignalR)
            return Task.CompletedTask;
        }

        public Task HandleEventAsync(BookingCancelledEvent eventData)
        {
            // TODO: Notify teacher/admin
            return Task.CompletedTask;
        }

        public Task HandleEventAsync(BookingBlockedEvent eventData)
        {
            // TODO: Notify affected teacher
            return Task.CompletedTask;
        }
    }

}
