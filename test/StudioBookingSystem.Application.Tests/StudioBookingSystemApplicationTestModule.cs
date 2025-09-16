using Volo.Abp.Modularity;

namespace StudioBookingSystem;

[DependsOn(
    typeof(StudioBookingSystemApplicationModule),
    typeof(StudioBookingSystemDomainTestModule)
)]
public class StudioBookingSystemApplicationTestModule : AbpModule
{

}
