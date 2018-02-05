using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Computer
    {
        public string Model { get; set; }
        public string Description { get; set; }

        public abstract string GetOptionCode();
        public abstract decimal GetPrice();
    }
}
