using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface IPaymentReceipt
    {
        Order Order { get; set; }

        Receipt Receipt { get; }
    }
}
