using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme.Management.EntityFrameworkCore
{
    [DependsOn(
        typeof(BootstrapThemeDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class BootstrapThemeEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BootstrapThemeDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}