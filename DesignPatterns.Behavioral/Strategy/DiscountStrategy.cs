using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public abstract class DiscountStrategy
    {
        protected decimal discountPercentage { get; set; }

        public abstract decimal ApplyDiscount(decimal saleAmount);
    }
}
