using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.BootstrapTheme.Management
{
    public abstract class BootstrapThemeController : AbpController
    {
        protected BootstrapThemeController()
        {
            LocalizationResource = typeof(BootstrapThemeResource);
        }
    }
}
