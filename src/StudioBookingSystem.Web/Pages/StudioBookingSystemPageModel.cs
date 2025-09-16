using StudioBookingSystem.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StudioBookingSystem.Web.Pages;

public abstract class StudioBookingSystemPageModel : AbpPageModel
{
    protected StudioBookingSystemPageModel()
    {
        LocalizationResourceType = typeof(StudioBookingSystemResource);
    }
}
