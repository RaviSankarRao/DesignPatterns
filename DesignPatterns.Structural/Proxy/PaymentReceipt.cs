using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    // Real class - that actually does the payment processing

    public class PaymentReceipt : IPaymentReceipt
    {
        public Order Order { get; set; }

        public Receipt Receipt
        {
            get
            {
                return GetReceipt();
            }
        }

        private Receipt GetReceipt()
        {
            // contact payment processor with order info
            // this may be an asynchronous operation

            // once processing is donw
            Receipt receipt = new Receipt();
            receipt.OrderId = Order.OrderId;
            receipt.AmountPaid = Order.Amount;
            receipt.ConfirmationNumber = "123456";
            receipt.DatePaid = DateTime.Now;

            return receipt;
        }
    }
}
