using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.BootstrapTheme.Management.MongoDB
{
    public static class BootstrapThemeMongoDbContextExtensions
    {
        public static void ConfigureBootstrapTheme(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BootstrapThemeMongoModelBuilderConfigurationOptions(
                BootstrapThemeDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}