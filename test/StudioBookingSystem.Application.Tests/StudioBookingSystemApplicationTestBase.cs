using Volo.Abp.Modularity;

namespace StudioBookingSystem;

public abstract class StudioBookingSystemApplicationTestBase<TStartupModule> : StudioBookingSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
