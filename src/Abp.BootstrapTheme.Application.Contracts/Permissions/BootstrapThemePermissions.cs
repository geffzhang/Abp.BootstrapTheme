using Volo.Abp.Reflection;

namespace Abp.BootstrapTheme.Management.Permissions
{
    public class BootstrapThemePermissions
    {
        public const string GroupName = "BootstrapTheme";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BootstrapThemePermissions));
        }
    }
}