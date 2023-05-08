using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Abp.BootstrapThemeUI;

namespace Abp.PermissionManagement.Blazor.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpBootstrapBlazorUIModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpPermissionManagementApplicationContractsModule)
)]
public class AbpPermissionManagementBlazorBootstrapBlazorModule : AbpModule
{

}
