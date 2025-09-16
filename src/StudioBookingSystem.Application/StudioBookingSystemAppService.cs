using StudioBookingSystem.Localization;
using Volo.Abp.Application.Services;

namespace StudioBookingSystem;

/* Inherit your application services from this class.
 */
public abstract class StudioBookingSystemAppService : ApplicationService
{
    protected StudioBookingSystemAppService()
    {
        LocalizationResource = typeof(StudioBookingSystemResource);
    }
}
