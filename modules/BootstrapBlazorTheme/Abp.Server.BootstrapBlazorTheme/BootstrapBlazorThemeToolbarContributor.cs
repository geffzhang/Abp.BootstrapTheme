using System.Threading.Tasks;
using Abp.AspnetCore.Components.Server.BootstrapBlazorTheme.Themes.BootstrapBlazorTheme;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;

namespace Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;


public class BootstrapBlazorThemeToolbarContributor: IToolbarContributor
{
    public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == StandardToolbars.Main)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
        }

        return Task.CompletedTask;
    }
}
