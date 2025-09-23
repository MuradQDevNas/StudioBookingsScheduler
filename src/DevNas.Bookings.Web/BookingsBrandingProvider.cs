using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using DevNas.Bookings.Localization;

namespace DevNas.Bookings.Web;

[Dependency(ReplaceServices = true)]
public class BookingsBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookingsResource> _localizer;

    public BookingsBrandingProvider(IStringLocalizer<BookingsResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
