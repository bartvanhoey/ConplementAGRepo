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

            var contactPermission = myGroup.AddPermission(ConplementAGPermissions.Contact.Default, L("Permission:Contact"));
            contactPermission.AddChild(ConplementAGPermissions.Contact.Create, L("Permission:Create"));
            contactPermission.AddChild(ConplementAGPermissions.Contact.Update, L("Permission:Update"));
            contactPermission.AddChild(ConplementAGPermissions.Contact.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ConplementAGResource>(name);
        }
    }
}
