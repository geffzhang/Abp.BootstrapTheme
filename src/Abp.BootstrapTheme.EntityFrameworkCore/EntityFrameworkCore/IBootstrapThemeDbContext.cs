using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.BootstrapTheme.Management.EntityFrameworkCore
{
    [ConnectionStringName(BootstrapThemeDbProperties.ConnectionStringName)]
    public interface IBootstrapThemeDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}