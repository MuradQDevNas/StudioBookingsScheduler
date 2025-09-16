using Volo.Abp.Modularity;

namespace StudioBookingSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class StudioBookingSystemDomainTestBase<TStartupModule> : StudioBookingSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
