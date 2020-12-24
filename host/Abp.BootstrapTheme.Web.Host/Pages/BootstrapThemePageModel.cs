using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.BootstrapTheme.Pages
{
    public abstract class BootstrapThemePageModel : AbpPageModel
    {
        protected BootstrapThemePageModel()
        {
            LocalizationResourceType = typeof(BootstrapThemeResource);
        }
    }
}