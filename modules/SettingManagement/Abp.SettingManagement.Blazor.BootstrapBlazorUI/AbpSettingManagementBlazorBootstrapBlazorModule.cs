using Microsoft.Extensions.DependencyInjection;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Routing;
using Abp.SettingManagement.Blazor.BootstrapBlazorUI.Settings;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Blazor;
using Volo.Abp.UI.Navigation;

namespace Abp.SettingManagement.Blazor.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpAutoMapperModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebBootstrapBlazorThemeModule)
)]
public class AbpSettingManagementBlazorBootstrapBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpSettingManagementBlazorBootstrapBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<SettingManagementBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new SettingManagementMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpSettingManagementBlazorBootstrapBlazorModule).Assembly);
        });

        Configure<SettingManagementComponentOptions>(options =>
        {
            options.Contributors.Add(new BootstrapBlazorSettingDefultPageContributor());
        });
    }
}
