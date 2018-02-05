using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class Usage
    {
        public void DisplayPattern()
        {
            User user = new User("Bob");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 for Login");
                Console.WriteLine("2 for Upgrade");
                Console.WriteLine("3 for Logout");

                Console.Write("Enter Selection : ");

                int selection = Convert.ToInt32(Console.ReadLine());

                switch(selection)
                {
                    case 1:
                        user.Login();
                        Console.WriteLine("Next Page : {0}", user.NexPage);
                        break;
                    case 2:
                        user.Upgrade();
                        Console.WriteLine("Next Page : {0}", user.NexPage);
                        break;
                    case 3:
                        user.LogOut();
                        Console.WriteLine("Next Page : {0}", user.NexPage);
                        break;
                }
            }
        }
    }
}
