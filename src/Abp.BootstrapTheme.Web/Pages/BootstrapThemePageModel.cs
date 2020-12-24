using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.BootstrapTheme.Management.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BootstrapThemePageModel : AbpPageModel
    {
        protected BootstrapThemePageModel()
        {
            LocalizationResourceType = typeof(BootstrapThemeResource);
            ObjectMapperContext = typeof(BootstrapThemeWebModule);
        }
    }
}