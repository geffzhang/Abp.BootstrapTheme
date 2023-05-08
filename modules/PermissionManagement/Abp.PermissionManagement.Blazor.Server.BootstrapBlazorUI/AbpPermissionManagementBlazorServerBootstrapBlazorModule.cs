using Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Abp.PermissionManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpPermissionManagementBlazorServerBootstrapBlazorModule : AbpModule
{

}
