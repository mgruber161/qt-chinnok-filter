using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CommonBase.Modules.Configuration
{
    partial class Configurator
    {
        static partial void ClassConstructed()
        {
#if DEBUG && SQLITE_ON
            Environment.SetEnvironmentVariable("ConnectionStrings:SqliteDefaultConnection",
 "Data Source=D:\\Repos\\data\\sqlite\\chinook\\chinook.db");
#endif
        }
    }
}