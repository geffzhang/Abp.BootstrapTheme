using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.BootstrapTheme.Management.MongoDB
{
    public class BootstrapThemeMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public BootstrapThemeMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}