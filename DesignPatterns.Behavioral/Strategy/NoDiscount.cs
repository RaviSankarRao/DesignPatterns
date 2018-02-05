using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class NoDiscount : DiscountStrategy
    {
        public NoDiscount()
        {
            discountPercentage = 0;
        }

        public override decimal ApplyDiscount(decimal saleAmount)
        {
            return (decimal)(100 - discountPercentage) * saleAmount / 100;
        }
    }
}
