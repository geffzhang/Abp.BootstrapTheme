using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Abp.BootstrapTheme.Management
{
    [DependsOn(
        typeof(BootstrapThemeDomainModule),
        typeof(BootstrapThemeApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class BootstrapThemeApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<BootstrapThemeApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BootstrapThemeApplicationModule>(validate: true);
            });
        }
    }
}
