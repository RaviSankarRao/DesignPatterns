using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            //if(databaseType == DatabaseType.SqlServer)
            //{
            //    return new SqlServerDatabase();
            //}
            //else
            //{
            //    return new OleDbDatabase();
            //}

            switch(databaseType)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                case DatabaseType.OleDb:
                default:
                    return new OleDbDatabase();

            }
        }
    }
}
