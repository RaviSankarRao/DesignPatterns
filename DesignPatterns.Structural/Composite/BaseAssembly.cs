using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public abstract class BaseAssembly
    {
        protected string name;
        protected int quantity;

        public BaseAssembly(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public abstract void Add(BaseAssembly assembly);
        public abstract void Remove(BaseAssembly assembly);
        public abstract void WritePartsList(List<string> list);
    }
}
