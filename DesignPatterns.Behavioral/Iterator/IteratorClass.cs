using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class IteratorClass : IIterator
    {
        IAggregate aggregate = null;
        int index = 0;

        public IteratorClass(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public User First
        {
            get
            {
                index = 0;
                return aggregate[index];
            }
        }

        public User Next
        {
            get
            {
                index += 1;

                if(!isDone)
                {
                    return aggregate[index];
                }
                else
                {
                    return null;
                }
            }
        }

        public User Current
        {
            get
            {
                return aggregate[index];
            }
        }

        public bool isDone
        {
            get
            {
                return index >= aggregate.count;
            }
        }
    }
}
