namespace CommonBase.Modules.Configuration
{
    partial class Configurator
    {
        static partial void ClassConstructed()
        {
#if DEBUG && SQLITE_ON
            Environment.SetEnvironmentVariable("ConnectionStrings:SqliteDefaultConnection", "Data Source=C:\\Users\\ggehr\\source\\repos\\leoggehrer\\Data\\chinook.db");
#endif
        }
    }
}
