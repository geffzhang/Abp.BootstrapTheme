using BootstrapBlazor.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.ObjectMapping;
using Volo.Abp.UI.Navigation;

namespace Abp.AspNetCore.Components.WebAssembly.BootstrapTheme.Components.ApplicationLayout
{
    public class MainMenuProvider : ISingletonDependency
    {
        private readonly IMenuManager _menuManager;
        private readonly IObjectMapper<AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule> _objectMapper;
        private readonly IBootstrapSettingsProvider _bootstrapSettings;

        private List<MenuItem> Menu { get; set; }

        public MainMenuProvider(
            IMenuManager menuManager,
            IObjectMapper<AbpAspNetCoreComponentsWebAssemblyBootstrapThemeModule> objectMapper,
            IBootstrapSettingsProvider bootstrapSettings)
        {
            _menuManager = menuManager;
            _objectMapper = objectMapper;
            _bootstrapSettings = bootstrapSettings;
        }

        public async Task<List<MenuItem>> GetMenuAsync()
        {
            if (Menu == null)
            {
                var ret = new List<MenuItem>();

                var menu = await _menuManager.GetAsync(StandardMenus.Main);
                var list = menu.Items;                
                foreach(var item in list)
                {
                    var menuItem = new MenuItem() { Text = item.DisplayName, Icon = item.Icon, Url = item.Url };
                    if(item.Items.Count >0)
                    {
                        AddMenuItem(item, menuItem);
                    }
                    ret.Add(menuItem);
                }


                return ret;
            }

            return Menu;
        }

        private static void AddMenuItem(ApplicationMenuItem item, MenuItem menuItem)
        {
            foreach (var appMenuItem in item.Items)
            {
                var menuItemInfo = new MenuItem() { Text = appMenuItem.DisplayName, Icon = appMenuItem.Icon, Url = appMenuItem.Url };
                if (item.Items.Count > 0)
                {
                    AddMenuItem(appMenuItem, menuItemInfo);
                }
                menuItem.AddItem(menuItemInfo);
            }
        }
    }
}
