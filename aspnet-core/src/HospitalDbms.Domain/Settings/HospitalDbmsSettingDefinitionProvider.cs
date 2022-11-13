using Volo.Abp.Settings;

namespace HospitalDbms.Settings;

public class HospitalDbmsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HospitalDbmsSettings.MySetting1));
    }
}
