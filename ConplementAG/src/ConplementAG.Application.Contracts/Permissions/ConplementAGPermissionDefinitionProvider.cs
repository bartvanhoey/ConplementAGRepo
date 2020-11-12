using ConplementAG.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ConplementAG.Permissions
{
    public class ConplementAGPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ConplementAGPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ConplementAGPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ConplementAGResource>(name);
        }
    }
}
