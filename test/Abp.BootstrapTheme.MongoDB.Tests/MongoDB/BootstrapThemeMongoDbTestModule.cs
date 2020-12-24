using Abp.BootstrapTheme.Management.MongoDB;
using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme.MongoDB
{
    [DependsOn(
        typeof(BootstrapThemeTestBaseModule),
        typeof(BootstrapThemeMongoDbModule)
        )]
    public class BootstrapThemeMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = MongoDbFixture.ConnectionString.Split('?');
            var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                       "Db_" +
                                   Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
