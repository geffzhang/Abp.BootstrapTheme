using Abp.AspnetCore.Components.WebAssembly.BootstrapBlazorTheme;
using Abp.FeatureManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;

namespace Abp.FeatureManagement.Blazor.WebAssembly.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpFeatureManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyBootstrapBlazorThemeModule),
    typeof(AbpFeatureManagementHttpApiClientModule)
)]
public class AbpFeatureManagementBlazorWebAssemblyBootstrapBlazorModule : AbpModule
{
}
