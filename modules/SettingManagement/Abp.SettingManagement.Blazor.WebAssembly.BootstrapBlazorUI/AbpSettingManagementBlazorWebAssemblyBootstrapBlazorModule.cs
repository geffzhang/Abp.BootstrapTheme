using Abp.AspnetCore.Components.WebAssembly.BootstrapBlazorTheme;
using Abp.SettingManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace Abp.SettingManagement.Blazor.WebAssembly.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpSettingManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyBootstrapBlazorThemeModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class AbpSettingManagementBlazorWebAssemblyBootstrapBlazorModule : AbpModule
{
    
}
