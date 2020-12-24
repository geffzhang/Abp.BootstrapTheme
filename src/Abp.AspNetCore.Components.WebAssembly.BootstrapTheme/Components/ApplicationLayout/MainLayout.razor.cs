// **********************************
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.AspNetCore.Components.WebAssembly.BootstrapTheme.Components.ApplicationLayout
{
    public partial class MainLayout
    {
        private bool UseTabSet { get; set; }

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
    }
}
