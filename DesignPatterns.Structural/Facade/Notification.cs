using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Notification
    {
        public bool NotifyUser(User user, string message)
        {
            // code for notification
            // moght be SMS, email, internal app messaging etc.

            Console.WriteLine("You are logged in as {0}\n{1}", user.UserName,message);

            return true;
        }
    }
}
