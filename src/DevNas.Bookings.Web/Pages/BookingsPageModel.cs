using DevNas.Bookings.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DevNas.Bookings.Web.Pages;

public abstract class BookingsPageModel : AbpPageModel
{
    protected BookingsPageModel()
    {
        LocalizationResourceType = typeof(BookingsResource);
    }
}
