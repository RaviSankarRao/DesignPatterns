using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    interface IDatabase
    {
        DbConnection Connection { get; set; }

        DbCommand Command { get; set; }
    }
}
