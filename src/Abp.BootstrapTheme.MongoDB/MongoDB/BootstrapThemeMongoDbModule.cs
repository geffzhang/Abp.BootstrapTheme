using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Abp.BootstrapTheme.Management.MongoDB
{
    [DependsOn(
        typeof(BootstrapThemeDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class BootstrapThemeMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<BootstrapThemeMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
