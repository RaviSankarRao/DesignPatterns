using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public abstract class Database
    {
        public virtual DbConnection Connection { get; set; }

        public virtual DbCommand Command { get; set; }
    }
}
