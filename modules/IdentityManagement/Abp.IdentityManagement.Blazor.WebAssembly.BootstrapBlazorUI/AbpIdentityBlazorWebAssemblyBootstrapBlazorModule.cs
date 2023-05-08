using Abp.IdentityManagement.Blazor.BootstrapBlazorUI;
using Abp.PermissionManagement.Blazor.WebAssembly.BootstrapBlazorUI;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Abp.IdentityManagement.Blazor.WebAssembly.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpIdentityBlazorBootstrapBlazorModule),
    typeof(AbpPermissionManagementBlazorWebAssemblyBootstrapBlazorModule),
    typeof(AbpIdentityHttpApiClientModule)
)]
public class AbpIdentityBlazorWebAssemblyBootstrapBlazorModule: AbpModule
{
}
