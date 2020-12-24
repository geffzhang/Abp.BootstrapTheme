using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Abp.BootstrapTheme.Management
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class BootstrapThemeDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BootstrapThemeDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<BootstrapThemeResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/BootstrapTheme");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("BootstrapTheme", typeof(BootstrapThemeResource));
            });
        }
    }
}
