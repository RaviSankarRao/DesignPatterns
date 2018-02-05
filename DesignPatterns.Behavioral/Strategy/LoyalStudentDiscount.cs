using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class LoyalStudentDiscount : DiscountStrategy
    {
        public LoyalStudentDiscount()
        {
            discountPercentage = 33;
        }

        public override decimal ApplyDiscount(decimal saleAmount)
        {
            return (decimal)(100 - discountPercentage) * saleAmount / 100;
        }
    }
}
