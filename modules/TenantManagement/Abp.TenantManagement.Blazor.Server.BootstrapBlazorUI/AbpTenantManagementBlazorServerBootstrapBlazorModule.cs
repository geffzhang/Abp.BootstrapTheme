using Abp.FeatureManagement.Blazor.Server.BootstrapBlazorUI;
using Abp.TenantManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Abp.TenantManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpTenantManagementBlazorBootstrapBlazorModule),
    typeof(AbpFeatureManagementBlazorWebServerBootstrapBlazorModule)
)]
public class AbpTenantManagementBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
