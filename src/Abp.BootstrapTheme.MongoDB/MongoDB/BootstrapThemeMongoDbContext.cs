using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.BootstrapTheme.Management.MongoDB
{
    [ConnectionStringName(BootstrapThemeDbProperties.ConnectionStringName)]
    public class BootstrapThemeMongoDbContext : AbpMongoDbContext, IBootstrapThemeMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureBootstrapTheme();
        }
    }
}