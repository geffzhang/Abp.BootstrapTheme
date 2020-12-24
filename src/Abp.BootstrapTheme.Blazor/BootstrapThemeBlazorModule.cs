using Microsoft.Extensions.DependencyInjection;
using Abp.BootstrapTheme.Management.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Abp.BootstrapTheme.Management.Blazor
{
    [DependsOn(
        typeof(BootstrapThemeHttpApiClientModule),
        typeof(AbpAutoMapperModule)
        )]
    public class BootstrapThemeBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<BootstrapThemeBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<BootstrapThemeBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new BootstrapThemeMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(BootstrapThemeBlazorModule).Assembly);
            });
        }
    }
}