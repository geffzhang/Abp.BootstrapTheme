using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.BootstrapTheme.Management.EntityFrameworkCore
{
    [ConnectionStringName(BootstrapThemeDbProperties.ConnectionStringName)]
    public class BootstrapThemeDbContext : AbpDbContext<BootstrapThemeDbContext>, IBootstrapThemeDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public BootstrapThemeDbContext(DbContextOptions<BootstrapThemeDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBootstrapTheme();
        }
    }
}