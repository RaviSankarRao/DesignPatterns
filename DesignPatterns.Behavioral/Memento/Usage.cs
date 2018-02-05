using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Usage
    {
        public void DisplayPattern()
        {
            User user = new User();
            user.UserId = 1;
            user.Name = "Bob";
            user.UserName = "Bob_Builder";
            user.Password = "Password";
            
            DisplayUser(user);

            Console.Write("Enter new name : ");
            string name = Console.ReadLine();

            Caretaker caretaker = new Caretaker();
            caretaker.UserMemento = user.SaveState();

            user.Name = name;
            Console.WriteLine();
            Console.WriteLine("Object changed");

            DisplayUser(user);

            user.RestoreState(caretaker.UserMemento);
            Console.WriteLine();
            Console.WriteLine("Object restored");

            DisplayUser(user);
        }

        private void DisplayUser(User user)
        {
            Console.WriteLine("User details");
            Console.WriteLine("Id " + user.UserId);
            Console.WriteLine("Name "+user.Name);
        }
    }
}
