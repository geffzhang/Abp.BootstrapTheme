using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.Application.Services;

namespace Abp.BootstrapTheme.Management
{
    public abstract class BootstrapThemeAppService : ApplicationService
    {
        protected BootstrapThemeAppService()
        {
            LocalizationResource = typeof(BootstrapThemeResource);
            ObjectMapperContext = typeof(BootstrapThemeApplicationModule);
        }
    }
}
