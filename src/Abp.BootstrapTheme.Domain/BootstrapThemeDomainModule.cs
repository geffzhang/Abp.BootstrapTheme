using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme.Management
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(BootstrapThemeDomainSharedModule)
    )]
    public class BootstrapThemeDomainModule : AbpModule
    {

    }
}
