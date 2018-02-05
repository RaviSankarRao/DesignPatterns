using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Usage
    {
        private IPaymentReceipt paymentReceipt;

        public void displayPattern()
        {
            Order order = new Order
            {
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                CustomerId = "Cusomer - 2",
                Amount = 100,
                CreditCard = "1234567890",
                Expiration = "5/15"
            };

            paymentReceipt = new PaymentReceiptProxy
            {
                Order = order
            };

            Receipt receipt = paymentReceipt.Receipt;

            DisplayReceipt(receipt);

            Thread.Sleep(3000);

            RefreshProxy();
        }

        private void DisplayReceipt(Receipt receipt)
        {
            Console.WriteLine();
            Console.WriteLine(receipt.ConfirmationNumber);
            Console.WriteLine(receipt.AmountPaid);
            Console.WriteLine(receipt.DatePaid);
        }

        private void RefreshProxy()
        {
            Receipt receipt = paymentReceipt.Receipt;
            DisplayReceipt(receipt);
        }
    }
}
