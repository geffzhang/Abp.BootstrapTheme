using Abp.BootstrapTheme.Management;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme
{
    [DependsOn(
        typeof(BootstrapThemeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BootstrapThemeConsoleApiClientModule : AbpModule
    {
        
    }
}
