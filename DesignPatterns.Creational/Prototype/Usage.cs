using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Usage
    {
        User Admin;
        User AdminClone;
        User AdminDeepClone;

        public void createClone()
        {
            Admin = new Admin
            {
                FirstName = "Ravi",
                LastName = "Rao",
                UserName = "ravi_rao",

                HomeAddress = new Address
                {
                    Address1 = "1428",
                    Address2 = "166th PL NE",
                    City = "Bellevue",
                    State = "WA",
                    Zip = "98008"
                },

                BusinessAddress = new Address
                {
                    Address1 = "15205",
                    Address2 = "156th Ave NE 8th St",
                    City = "Bellevue",
                    State = "WA",
                    Zip = "98008"
                },
            };

            AdminClone = (User)Admin.Clone();
            AdminDeepClone = Admin.DeepClone();
        }

        public void discussPrototype()
        {
            createClone();

            Console.WriteLine("User names of various objects");
            Console.WriteLine("Admin : {0}", Admin.UserName);
            Console.WriteLine("Admin Clone: {0}", AdminClone.UserName);
            Console.WriteLine("Admin Deep Clone: {0}", AdminDeepClone.UserName);

            Console.WriteLine();
            Console.WriteLine("Enter new user name");
            string userName = Console.ReadLine();

            Admin.UserName = userName;

            Console.WriteLine();
            Console.WriteLine("User names of various objects after update");
            Console.WriteLine("Admin : {0}", Admin.UserName);
            Console.WriteLine("Admin Clone: {0}", AdminClone.UserName);
            Console.WriteLine("Admin Deep Clone: {0}", AdminDeepClone.UserName);

            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.WriteLine("City of Home address of various objects");
            Console.WriteLine("Admin : {0}", Admin.HomeAddress.City);
            Console.WriteLine("Admin Clone: {0}", AdminClone.HomeAddress.City);
            Console.WriteLine("Admin Deep Clone: {0}", AdminDeepClone.HomeAddress.City);

            Console.WriteLine();
            Console.WriteLine("Enter new city");
            string city = Console.ReadLine();

            Admin.HomeAddress.City = city;

            Console.WriteLine();
            Console.WriteLine("City of Home address of various objects after update");
            Console.WriteLine("Admin : {0}", Admin.HomeAddress.City);
            Console.WriteLine("Admin Clone: {0}", AdminClone.HomeAddress.City);
            Console.WriteLine("Admin Deep Clone: {0}", AdminDeepClone.HomeAddress.City);

            Console.WriteLine();
        }
    }
}
