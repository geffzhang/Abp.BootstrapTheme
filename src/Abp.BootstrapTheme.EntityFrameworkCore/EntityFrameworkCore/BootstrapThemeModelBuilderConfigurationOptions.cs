using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.BootstrapTheme.Management.EntityFrameworkCore
{
    public class BootstrapThemeModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public BootstrapThemeModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}