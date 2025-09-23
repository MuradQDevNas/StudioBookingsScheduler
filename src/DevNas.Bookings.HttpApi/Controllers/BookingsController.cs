using DevNas.Bookings.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DevNas.Bookings.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookingsController : AbpControllerBase
{
    protected BookingsController()
    {
        LocalizationResource = typeof(BookingsResource);
    }
}
