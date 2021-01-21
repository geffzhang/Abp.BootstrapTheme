// **********************************
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;

namespace Abp.AspNetCore.Components.WebAssembly.BootstrapTheme.Components.ApplicationLayout
{
    public partial class MainLayout
    {
        protected bool UseTabSet { get; set; } = true;

        [Inject]
        protected IOptions<AbpRouterOptions> RouterOptions { get; set; }

        [Inject]
        protected MainMenuProvider MainMenuProvider { get; set; }

        /// <summary>
        /// 获得/设置 是否固定页头
        /// </summary>
        [Parameter]
        public bool IsFixedHeader { get; set; } = true;

        /// <summary>
        /// 获得/设置 是否固定页脚
        /// </summary>
        [Parameter]
        public bool IsFixedFooter { get; set; } = true;

        /// <summary>
        /// 获得/设置 侧边栏是否外置
        /// </summary>
        [Parameter]
        public bool IsFullSide { get; set; } = true;

        /// <summary>
        /// 获得/设置 是否显示页脚
        /// </summary>
        [Parameter]
        public bool ShowFooter { get; set; } = true;

        /// <summary>
        /// 更新组件方法
        /// </summary>
        public void Update() => StateHasChanged();

        private List<MenuItem> Menus { get; set; }

        /// OnInitialized 方法
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();
            Menus = await GetIconSideMenuItems();
        }

       // TODO: 菜单获取可以通过数据库获取，此处为示例直接拼装的菜单集合

        private async Task<List<MenuItem>> GetIconSideMenuItems()
        {
            return await MainMenuProvider.GetMenuAsync();  
        }

        private IEnumerable<Assembly> GetAdditionalAssemblies()
        {
            List<Assembly> list = new List<Assembly>();
            var asmyList =  RouterOptions.Value.AdditionalAssemblies;
            var asm = RouterOptions.Value.AppAssembly;
            
            list = asmyList.ToList();
            if(!list.Contains(asm))
            {
                list.Add(asm);
            }
            return list;
        }
    }
}
