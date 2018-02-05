using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Usage
    {
        User greg = new User("Greg", DateTime.Now, 25);
        User richard = new User("Richard", DateTime.Now.AddMonths(-6), 42);
        Users users = new Users();

        public void DisplayPattern()
        {
            users.Attach(greg);
            users.Attach(richard);

            Console.WriteLine("Before visitor applied");
            DisplayUsers();

            users.Accept(new CreditVisitor());

            Console.WriteLine("After credit visitor");
            DisplayUsers();

            users.Accept(new ExpirationVisitor());

            Console.WriteLine("After expiration visitor");
            DisplayUsers();
        }

        private void DisplayUsers()
        {
            Thread.Sleep(2000);
            Console.WriteLine(greg.Name + ", " + greg.ExpirationDate + ", " + greg.Credits);
            Console.WriteLine(richard.Name + ", " + richard.ExpirationDate + ", " + richard.Credits);
            Console.WriteLine();
        }
    }
}
