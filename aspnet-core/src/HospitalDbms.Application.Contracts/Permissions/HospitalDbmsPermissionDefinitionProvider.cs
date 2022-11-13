using HospitalDbms.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HospitalDbms.Permissions;

public class HospitalDbmsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HospitalDbmsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HospitalDbmsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HospitalDbmsResource>(name);
    }
}
