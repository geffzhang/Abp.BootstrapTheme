using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.BootstrapTheme.Management.MongoDB
{
    [ConnectionStringName(BootstrapThemeDbProperties.ConnectionStringName)]
    public interface IBootstrapThemeMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
