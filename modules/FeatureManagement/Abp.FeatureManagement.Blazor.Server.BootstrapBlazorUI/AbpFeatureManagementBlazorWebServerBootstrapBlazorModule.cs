using Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Abp.FeatureManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Abp.FeatureManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpFeatureManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpFeatureManagementBlazorWebServerBootstrapBlazorModule : AbpModule
{
}
