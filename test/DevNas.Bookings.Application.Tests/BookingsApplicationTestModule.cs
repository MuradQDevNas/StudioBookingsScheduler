using Volo.Abp.Modularity;

namespace DevNas.Bookings;

[DependsOn(
    typeof(BookingsApplicationModule),
    typeof(BookingsDomainTestModule)
)]
public class BookingsApplicationTestModule : AbpModule
{

}
