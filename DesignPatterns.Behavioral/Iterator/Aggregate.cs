using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Aggregate : IAggregate
    {
        List<User> values = null;

        public Aggregate()
        {
            values = new List<User>();
        }

        public IIterator GetIterator()
        {
            // below allows the iterator to iterate on this collection this class contains
            return new IteratorClass(this);
        }

        public User this[int index]
        {
            get
            {
                if(index<values.Count)
                {
                    return values[index];
                }
                else
                {
                    // return null or throw exception
                    return null;
                }
            }

            set
            {
                values.Add(value);
            }
        }

        public int count
        {
            get
            {
                return values.Count;
            }
        }
    }
}
