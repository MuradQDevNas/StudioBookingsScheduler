using DevNas.Bookings.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DevNas.Bookings.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookingsEntityFrameworkCoreModule),
    typeof(BookingsApplicationContractsModule)
)]
public class BookingsDbMigratorModule : AbpModule
{
}
