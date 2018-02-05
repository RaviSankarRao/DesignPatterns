using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class OleDbDatabaseBuilder : IDatabaseBuilder
    {
        private Database _Database;

        public OleDbDatabaseBuilder()
        {
            _Database = new OleDBDatabase();
        }

        public void BuildCommand()
        {
            //Read connection string from configuration manager
            string connectionString = "";

            _Database.Connection = new OleDbConnection(connectionString);
        }

        public void BuildConnection()
        {
            _Database.Command = new OleDbCommand();
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
