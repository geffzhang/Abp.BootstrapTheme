using Abp.BootstrapTheme.Management;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme
{
    [DependsOn(
        typeof(BootstrapThemeApplicationModule),
        typeof(BootstrapThemeDomainTestModule)
        )]
    public class BootstrapThemeApplicationTestModule : AbpModule
    {

    }
}
