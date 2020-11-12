using Volo.Abp.Settings;

namespace ConplementAG.Settings
{
    public class ConplementAGSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ConplementAGSettings.MySetting1));
        }
    }
}
