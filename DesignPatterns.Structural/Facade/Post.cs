using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Post
    {
        public bool PostText(User user, string message)
        {
            // code for posting a simple text
            Console.WriteLine(message);

            return true;
        }
    }
}
