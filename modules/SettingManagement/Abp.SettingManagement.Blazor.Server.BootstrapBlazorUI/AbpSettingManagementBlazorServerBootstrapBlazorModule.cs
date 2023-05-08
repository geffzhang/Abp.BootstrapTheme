using Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Abp.SettingManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Abp.SettingManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpSettingManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpSettingManagementBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
