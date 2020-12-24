using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme.Management
{
    [DependsOn(
        typeof(BootstrapThemeApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BootstrapThemeHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "BootstrapTheme";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BootstrapThemeApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
