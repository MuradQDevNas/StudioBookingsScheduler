using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using StudioBookingSystem.Localization;

namespace StudioBookingSystem.Web;

[Dependency(ReplaceServices = true)]
public class StudioBookingSystemBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StudioBookingSystemResource> _localizer;

    public StudioBookingSystemBrandingProvider(IStringLocalizer<StudioBookingSystemResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
