using Volo.Abp.Modularity;

namespace DevNas.Bookings;

[DependsOn(
    typeof(BookingsDomainModule),
    typeof(BookingsTestBaseModule)
)]
public class BookingsDomainTestModule : AbpModule
{

}
