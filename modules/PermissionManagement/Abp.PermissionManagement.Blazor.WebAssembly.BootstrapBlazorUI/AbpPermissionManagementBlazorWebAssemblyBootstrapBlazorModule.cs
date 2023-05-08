using Abp.AspnetCore.Components.WebAssembly.BootstrapBlazorTheme;
using Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Abp.PermissionManagement.Blazor.WebAssembly.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyBootstrapBlazorThemeModule),
    typeof(AbpPermissionManagementHttpApiClientModule)
)]
public class AbpPermissionManagementBlazorWebAssemblyBootstrapBlazorModule : AbpModule
{

}
