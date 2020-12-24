using Abp.BootstrapTheme.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.BootstrapTheme
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(BootstrapThemeEntityFrameworkCoreTestModule)
        )]
    public class BootstrapThemeDomainTestModule : AbpModule
    {
        
    }
}
