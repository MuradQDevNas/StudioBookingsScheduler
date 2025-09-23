using DevNas.Bookings.Localization;
using Volo.Abp.Application.Services;

namespace DevNas.Bookings;

/* Inherit your application services from this class.
 */
public abstract class BookingsAppService : ApplicationService
{
    protected BookingsAppService()
    {
        LocalizationResource = typeof(BookingsResource);
    }
}
