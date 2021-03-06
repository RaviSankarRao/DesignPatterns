﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    class OleDbDatabase : IDatabase
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new OleDbConnection("connection string here");
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
                    _command = new OleDbCommand();
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
