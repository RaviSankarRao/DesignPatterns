using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string CreditCard { get; set; }

        public string Expiration { get; set; }

        public string CustomerId { get; set; }

        public decimal Amount { get; set; }
    }
}
