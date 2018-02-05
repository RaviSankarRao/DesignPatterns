using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class PaymentReceiptProxy : IPaymentReceipt
    {

        private bool _paymentProcessing = false;
        private bool _paymentProcessed = false;
        private PaymentReceipt _paymentReceipt = new PaymentReceipt();
        private Receipt _receipt = null;

        public Order Order { get; set; }

        public Receipt Receipt
        {
            get
            {
                if (_paymentProcessed)
                {
                    return _receipt;
                }
                else
                {

# region PAYMENT PROCESSING - Should be on a seperate thread

                    if (!_paymentProcessing)
                    {
                        _paymentProcessing = true;

                        // start CC approval process
                        // this should be on seperate thread

                        _paymentReceipt.Order = Order;
                        _receipt = _paymentReceipt.Receipt;
                        _paymentProcessing = false;
                        _paymentProcessed = true;
                    }
#endregion

                    return GetPlaceholderReceipt();
                }
            }
        }

        private Receipt GetPlaceholderReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.OrderId = Order.OrderId;
            receipt.AmountPaid = Order.Amount;
            receipt.ConfirmationNumber = "Processing payment...";
            receipt.DatePaid = DateTime.Now;
            return receipt;
        }
    }
}
