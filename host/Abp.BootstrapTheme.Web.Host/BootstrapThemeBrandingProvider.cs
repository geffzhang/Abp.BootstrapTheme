using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.BootstrapTheme
{
    [Dependency(ReplaceServices = true)]
    public class BootstrapThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BootstrapTheme";
    }
}
