using Abp.BootstrapTheme.Management.Localization;
using Microsoft.AspNetCore.Components;

namespace Abp.AspNetCore.Components.WebAssembly.BootstrapTheme.Pages
{
    public partial class Authentication 
    {
        [Parameter]
        public string Action { get; set; }

        public Authentication()
        {
            LocalizationResource = typeof(BootstrapThemeResource);
        }
    }
}
