using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class Director
    {
        public void Build(IDatabaseBuilder builder)
        {
            builder.BuildCommand();
            builder.BuildConnection();
            builder.SetSettings();
        }
    }
}
