using StudioBookingSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StudioBookingSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudioBookingSystemEntityFrameworkCoreModule),
    typeof(StudioBookingSystemApplicationContractsModule)
)]
public class StudioBookingSystemDbMigratorModule : AbpModule
{
}
