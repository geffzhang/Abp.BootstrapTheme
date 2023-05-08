using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Abp.AspnetCore.Components.Server.BootstrapBlazorTheme.Bundling;

public class BlazorBootstrapBlazorThemeStyleContributor: BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/_content/Abp.AspnetCore.Components.Web.BootstrapBlazorTheme/libs/abp/css/theme.css");
    }
}
