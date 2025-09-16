using StudioBookingSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudioBookingSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudioBookingSystemController : AbpControllerBase
{
    protected StudioBookingSystemController()
    {
        LocalizationResource = typeof(StudioBookingSystemResource);
    }
}
