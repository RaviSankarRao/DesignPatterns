using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class SqlServerDatabaseBuilder : IDatabaseBuilder
    {
        private Database _Database;

        public SqlServerDatabaseBuilder()
        {
            _Database = new SQLServerDatabase();
        }

        public void BuildCommand()
        {
            //Read connection string from configuration manager
            string connectionString = "";

            _Database.Connection = new SqlConnection(connectionString);
        }

        public void BuildConnection()
        {
            _Database.Command = new SqlCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void SetSettings()
        {
            _Database.Command.CommandTimeout = 360;
            _Database.Command.CommandType = CommandType.Text;
        }

        public Database Database
        {
            get
            {
                return _Database;
            }
        }
    }
}
