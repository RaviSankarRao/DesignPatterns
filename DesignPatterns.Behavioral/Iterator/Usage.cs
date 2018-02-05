using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Usage
    {
        public void DisplayPattern()
        {
            Aggregate aggregate = new Aggregate();
            aggregate[0] = new User { UserId = 1, Name = "Bob" };
            aggregate[1] = new User { UserId = 2, Name = "Bill" };
            aggregate[2] = new User { UserId = 3, Name = "Tom" };
            aggregate[3] = new User { UserId = 4, Name = "Rob" };
            aggregate[4] = new User { UserId = 5, Name = "Dan" };

            IIterator iterator = aggregate.GetIterator();

            string s = iterator.First.Name;

            while(!iterator.isDone)
            {
                User user = iterator.Next;
                if(user!=null)
                {
                    s += ", " + user.Name;
                }
            }

            Console.WriteLine(s);
        }
    }
}
