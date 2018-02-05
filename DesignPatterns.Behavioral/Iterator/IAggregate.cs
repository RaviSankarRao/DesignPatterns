using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public interface IAggregate
    {
        IIterator GetIterator();

        User this[int index] { get; set; }

        int count { get; }
    }
}
