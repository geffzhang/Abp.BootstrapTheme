using Abp.BootstrapTheme.Management.Localization;
using Abp.BootstrapTheme.Management.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.BootstrapTheme.Permissions
{
    public class BootstrapThemePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BootstrapThemePermissions.GroupName, L("Permission:BootstrapTheme"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BootstrapThemeResource>(name);
        }
    }
}