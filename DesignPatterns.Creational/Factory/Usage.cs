using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    class Usage
    {
        IDatabase database;

        public void getDatabase()
        {
            var databaseType = DatabaseType.SqlServer;

            database = DatabaseFactory.CreateDatabase(databaseType);

            // Your command and other logic here
        }
    }
}
