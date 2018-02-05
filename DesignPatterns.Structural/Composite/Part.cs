using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Part : BaseAssembly
    {
        public Part(string name, int quantity) 
            : base(name, quantity)
        {
        }

        public override void Add(BaseAssembly assembly)
        {
            throw new Exception("Single part object has no children");
        }

        public override void Remove(BaseAssembly assembly)
        {
            throw new Exception("Single part object has no children");
        }

        public override void WritePartsList(List<string> list)
        {
            list.Add(quantity.ToString() + " - " + name);
        }
    }
}
