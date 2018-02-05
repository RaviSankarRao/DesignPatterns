using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class Usage
    {
        Database database;

        public void getDatabase()
        {
            Director director = new Director();
            IDatabaseBuilder builder;

            bool useSqlServer = true;

            if(useSqlServer)
            {
                builder = new SqlServerDatabaseBuilder();
            }
            else
            {
                builder = new OleDbDatabaseBuilder();
            }

            director.Build(builder);

            database = builder.Database;

            DbCommand command = database.Command;
            command.CommandText = "Select * from Products";
            command.Connection.Open();

            DbDataReader reader = command.ExecuteReader();
            reader.Close();

            command.Connection.Close();
        }
    }
}
