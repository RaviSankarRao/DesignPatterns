using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Assembly : BaseAssembly
    {
        private List<BaseAssembly> elements = new List<BaseAssembly>();

        public Assembly(string name, int quantity) 
            : base(name, quantity)
        {
        }

        public override void Add(BaseAssembly assembly)
        {
            elements.Add(assembly);
        }

        public override void Remove(BaseAssembly assembly)
        {
            elements.Remove(assembly);
        }

        public override void WritePartsList(List<string> list)
        {
            list.Add(quantity.ToString() + " - " + name);

            foreach (var item in elements)
            {
                item.WritePartsList(list);
            }
        }
    }
}
