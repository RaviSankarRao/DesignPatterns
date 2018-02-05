using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class Usage
    {
        public void displayPattern()
        {
            ICustomerList customerList = new CustomerAdapter();

            Console.WriteLine("Enter no of Customers : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                CustomerDTO customer = new CustomerDTO
                {
                    Id = "CID" + i,
                    FirstName = "Customer",
                    LastName = i.ToString()
                };

                customerList.AddCustomer(customer);
            }

            List<Customer> customers = customerList.GetCustomers();

            foreach (var item in customers)
            {
                Console.WriteLine("Customer Id {0} has name {1}",item.CustomerId, item.Name);
            }
        }
    }
}
