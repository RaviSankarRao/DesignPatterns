using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Receipt
    {
        public string ConfirmationNumber { get; set; }

        public Guid OrderId { get; set; }

        public decimal AmountPaid{ get; set; }

        public DateTime DatePaid{ get; set; }
    }
}
