using Volo.Abp.Modularity;

namespace DevNas.Bookings;

/* Inherit from this class for your domain layer tests. */
public abstract class BookingsDomainTestBase<TStartupModule> : BookingsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
