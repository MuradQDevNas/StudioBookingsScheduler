using Volo.Abp.Modularity;

namespace StudioBookingSystem;

[DependsOn(
    typeof(StudioBookingSystemDomainModule),
    typeof(StudioBookingSystemTestBaseModule)
)]
public class StudioBookingSystemDomainTestModule : AbpModule
{

}
