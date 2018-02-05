using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class UserFactory
    {
        public static int usersCount = 0;
        private Dictionary<Guid, User> users = new Dictionary<Guid, User>();

        public User GetUser(Guid userId)
        {
            if (users.ContainsKey(userId))
                return users[userId];

            User user = User.GetUser(userId);
            users.Add(userId, user);
            usersCount++;

            return user;
        }
    }
}
