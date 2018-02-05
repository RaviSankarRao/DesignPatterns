using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class User
    {
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<User> Followers { get; set; }

        public static User GetUser(Guid userId)
        {
            return new User
            {
                UserId = Guid.NewGuid()
            };
        }
    }
}
