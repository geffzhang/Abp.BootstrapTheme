namespace Abp.BootstrapTheme.Management
{
    public static class BootstrapThemeDbProperties
    {
        public static string DbTablePrefix { get; set; } = "BootstrapTheme";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "BootstrapTheme";
    }
}
