using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using windows_ce.Properties;

using kpa.Data.SqlServerCe;

namespace windows_ce
{
    class Database
    {
        static string dbPath = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) +
                "\\database\\temp_database.sdf;Password=";
        public static string Connection
        {
            get { return dbPath; }
            set { dbPath = value; }
        }

    }
}
