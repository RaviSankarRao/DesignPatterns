using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Customer
    {
        DiscountStrategy discountStrategy;

        public void SetDiscountStrategy(DiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        // Customer object doesnt know what discount is to be applied
        // It is decided by the discount strategy
        // Without the Strategy pattern, Customer code would been length and cluttered with all conditions to decide discount

        public decimal ApplyDiscount(decimal saleAmmount)
        {
            return discountStrategy.ApplyDiscount(saleAmmount);
        }
    }
}
