using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        User First { get; }
        User Next { get; }
        User Current { get; }
        bool isDone { get; }
    }
}
