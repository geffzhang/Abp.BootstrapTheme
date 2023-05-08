using Microsoft.Extensions.DependencyInjection;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.ObjectExtending.Modularity;
using Volo.Abp.Threading;
using Volo.Abp.UI.Navigation;
using Abp.BootstrapThemeUI;
using Abp.PermissionManagement.Blazor.BootstrapBlazorUI;

namespace Abp.IdentityManagement.Blazor.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsWebBootstrapBlazorThemeModule),
    typeof(AbpBootstrapBlazorUIModule)
)]
public class AbpIdentityBlazorBootstrapBlazorModule: AbpModule
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpIdentityBlazorBootstrapBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<AbpIdentityBlazorBootstrapBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new AbpIdentityWebMainMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpIdentityBlazorBootstrapBlazorModule).Assembly);
        });
    }

    public override void PostConfigureServices(ServiceConfigurationContext context)
    {
        OneTimeRunner.Run(() =>
        {
            ModuleExtensionConfigurationHelper
                .ApplyEntityConfigurationToUi(
                    IdentityModuleExtensionConsts.ModuleName,
                    IdentityModuleExtensionConsts.EntityNames.Role,
                    createFormTypes: new[] { typeof(IdentityRoleCreateDto) },
                    editFormTypes: new[] { typeof(IdentityRoleUpdateDto) }
                );

            ModuleExtensionConfigurationHelper
                .ApplyEntityConfigurationToUi(
                    IdentityModuleExtensionConsts.ModuleName,
                    IdentityModuleExtensionConsts.EntityNames.User,
                    createFormTypes: new[] { typeof(IdentityUserCreateDto) },
                    editFormTypes: new[] { typeof(IdentityUserUpdateDto) }
                );
        });
    }
}
