using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Abp.BootstrapTheme.Management
{
    [DependsOn(
        typeof(BootstrapThemeDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class BootstrapThemeApplicationContractsModule : AbpModule
    {

    }
}
