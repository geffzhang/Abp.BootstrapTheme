using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.JSInterop;
using Syncfusion.Blazor;
using System;
using System.Globalization;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Abp.AspNetCore.Components.WebAssembly.BootstrapTheme
{

    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule),
        typeof(AbpAutoMapperModule)
        )]
    public class AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule).Assembly);
            });

            context.Services.AddAutoMapperObjectMapper<AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule>();
            });

            context.Services.AddBootstrapBlazor();
            context.Services.AddSyncfusionBlazor();
            context.Services.AddFeatureManagement();

            #region Localization
            // Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
            context.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

            // Set the default culture of the application
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("zh-CN");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("zh-CN");

            #endregion
        }

    }
}
