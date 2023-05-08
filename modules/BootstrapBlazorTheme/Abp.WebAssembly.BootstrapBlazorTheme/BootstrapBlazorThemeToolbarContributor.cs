﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;
using Abp.AspnetCore.Components.WebAssembly.BootstrapBlazorTheme.Themes.BootstrapBlazorTheme;

namespace Abp.AspnetCore.Components.WebAssembly.BootstrapBlazorTheme;

public class BootstrapBlazorThemeToolbarContributor: IToolbarContributor
{
    public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == StandardToolbars.Main)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));

            var authenticationStateProvider = context.ServiceProvider
                .GetRequiredService<AuthenticationStateProvider>();

            if (authenticationStateProvider != null)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
            }
        }

        return Task.CompletedTask;
    }
}
