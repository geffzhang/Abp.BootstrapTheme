using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Abp.BootstrapTheme.Management.EntityFrameworkCore;

namespace Abp.BootstrapTheme.EntityFrameworkCore
{
    public class BootstrapThemeHttpApiHostMigrationsDbContext : AbpDbContext<BootstrapThemeHttpApiHostMigrationsDbContext>
    {
        public BootstrapThemeHttpApiHostMigrationsDbContext(DbContextOptions<BootstrapThemeHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureBootstrapTheme();
        }
    }
}
