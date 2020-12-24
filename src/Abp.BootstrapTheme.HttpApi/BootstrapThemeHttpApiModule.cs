using Localization.Resources.AbpUi;
using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.BootstrapTheme.Management
{
    [DependsOn(
        typeof(BootstrapThemeApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BootstrapThemeHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BootstrapThemeHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BootstrapThemeResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
