using Abp.IdentityManagement.Blazor.BootstrapBlazorUI;
using Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Abp.IdentityManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpIdentityBlazorBootstrapBlazorModule),
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule)
)]
public class AbpIdentityBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
