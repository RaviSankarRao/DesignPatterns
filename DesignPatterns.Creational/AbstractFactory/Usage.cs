using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Usage
    {
        Database database;

        public void getDatabase()
        {
            bool useSqlServer = true;

            if(useSqlServer)
            {
                database = new SQLServerDatabase();
            }
            else
            {
                database = new OleDBDatabase();
            }
        }
    }
}
