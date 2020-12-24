using Abp.AspNetCore.Components.WebAssembly.BootstrapTheme;
using Abp.AspNetCore.Components.WebAssembly.BootstrapTheme.Components;
using Abp.BootstrapTheme.Management.Blazor;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using Volo.Abp.Account.Blazor;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.Autofac.WebAssembly;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Abp.BootstrapTheme.Blazor.Host
{
    [DependsOn(
        typeof(AbpAutofacWebAssemblyModule),
        typeof(AbpIdentityBlazorModule),
        typeof(AbpAccountBlazorModule),
        typeof(BootstrapThemeBlazorModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule)
    )]
    public class BootstrapThemeBlazorHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var environment = context.Services.GetSingletonInstance<IWebAssemblyHostEnvironment>();
            var builder = context.Services.GetSingletonInstance<WebAssemblyHostBuilder>();

            ConfigureAuthentication(builder);
            ConfigureHttpClient(context, environment);
            ConfigureBlazorise(context);
            ConfigureRouter(context);
            ConfigureUI(builder);
            ConfigureMenu(context);
            ConfigureAutoMapper(context);
        }

        private void ConfigureRouter(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AppAssembly = typeof(BootstrapThemeBlazorHostModule).Assembly;
            });
        }

        private void ConfigureMenu(ServiceConfigurationContext context)
        {
            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new BootstrapThemeHostMenuContributor());
            });
        }

        private void ConfigureBlazorise(ServiceConfigurationContext context)
        {
            context.Services
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();
        }

        private static void ConfigureAuthentication(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddOidcAuthentication(options =>
            {
                //builder.Configuration.Bind("AuthServer", options.ProviderOptions);
                options.ProviderOptions.DefaultScopes.Add("BootstrapTheme");
            });
        }

        private static void ConfigureUI(WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#ApplicationContainer");
        }

        private static void ConfigureHttpClient(ServiceConfigurationContext context, IWebAssemblyHostEnvironment environment)
        {
            context.Services.AddTransient(sp => new HttpClient
            {
                BaseAddress = new Uri(environment.BaseAddress)
            });
        }

        private void ConfigureAutoMapper(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BootstrapThemeBlazorHostModule>();
            });
        }
    }
}
