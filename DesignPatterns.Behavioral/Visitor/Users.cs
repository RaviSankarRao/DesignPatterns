using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Users
    {
        List<User> usersList = new List<User>();

        public void Attach(User user)
        {
            usersList.Add(user);
        }

        public void Detach(User user)
        {
            usersList.Remove(user);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (User user in usersList)
            {
                user.Accept(visitor);
            }
        }
    }
}
