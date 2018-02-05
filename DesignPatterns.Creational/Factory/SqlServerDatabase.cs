using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    class SqlServerDatabase : IDatabase
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection("connection string here");
                }
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        public DbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = Connection;
                }

                return _command;
            }
            set
            {
                _command = value;
            }
        }
    }
}
