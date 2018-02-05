using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    class CustomerAdapter : ICustomerList
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(CustomerDTO customer)
        {
            customers.Add(new Customer
            {
                CustomerId = customer.Id,
                Name = customer.FirstName + " " + customer.LastName,
                Address = customer.Address,
                City = customer.City,
                State = customer.State,
                Zip = customer.PostalCode
            });
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
