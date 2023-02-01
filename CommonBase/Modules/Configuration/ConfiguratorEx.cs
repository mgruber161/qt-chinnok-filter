namespace CommonBase.Modules.Configuration
{
    partial class Configurator
    {
        static partial void ClassConstructed()
        {
#if DEBUG && SQLITE_ON
            Environment.SetEnvironmentVariable("ConnectionStrings:SqliteDefaultConnection", "Data Source=/Users/ggehrer/Projects/Data/chinook.db");
#endif
        }
    }
}
