using Volo.Abp.Modularity;

namespace DevNas.Bookings;

public abstract class BookingsApplicationTestBase<TStartupModule> : BookingsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
