using Volo.Abp.Settings;

namespace DevNas.Bookings.Settings;

public class BookingsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookingsSettings.MySetting1));
    }
}
