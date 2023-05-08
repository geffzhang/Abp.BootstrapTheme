using Abp.FeatureManagement.Blazor.WebAssembly.BootstrapBlazorUI;
using Abp.TenantManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace Abp.TenantManagement.Blazor.WebAssembly.BootstrapBlazorUI;


[DependsOn(
    typeof(AbpTenantManagementBlazorBootstrapBlazorModule),
    typeof(AbpFeatureManagementBlazorWebAssemblyBootstrapBlazorModule),
    typeof(AbpTenantManagementHttpApiClientModule)
)]
public class AbpTenantManagementBlazorWebAssemblyBootstrapBlazorModule : AbpModule
{
    
}
