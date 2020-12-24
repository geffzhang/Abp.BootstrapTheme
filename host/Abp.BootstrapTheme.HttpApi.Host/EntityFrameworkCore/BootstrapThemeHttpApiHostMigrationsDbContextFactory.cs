using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.BootstrapTheme.EntityFrameworkCore
{
    public class BootstrapThemeHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BootstrapThemeHttpApiHostMigrationsDbContext>
    {
        public BootstrapThemeHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BootstrapThemeHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("BootstrapTheme"));

            return new BootstrapThemeHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
