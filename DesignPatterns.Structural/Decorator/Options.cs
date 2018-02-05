using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    class Memory8Option : ComputerDecorator
    {
        public Memory8Option(Computer computer) 
            : base(computer)
        {
            optionCode = "8 GB RAM";
            price = 70.0M;
        }
    }

    class Memory16Option : ComputerDecorator
    {
        public Memory16Option(Computer computer) 
            : base(computer)
        {
            optionCode = "16 GB RAM";
            price = 150.0M;
        }
    }

    class SSD128Option : ComputerDecorator
    {
        public SSD128Option(Computer computer) 
            : base(computer)
        {
            optionCode = "128 GB SSD";
            price = 75.0M;
        }
    }

    class SSD256Option : ComputerDecorator
    {
        public SSD256Option(Computer computer) 
            : base(computer)
        {
            optionCode = "256 GB SSD";
            price = 150.0M;
        }
    }

    class SSD512Option : ComputerDecorator
    {
        public SSD512Option(Computer computer) 
            : base(computer)
        {
            optionCode = "512 GB SSD";
            price = 250.0M;
        }
    }

    class DiscountDecorator : ComputerDecorator
    {
        private int discountRate = 5;

        public DiscountDecorator(Computer computer) 
            : base(computer)
        {
            this.optionCode = "Discount";
            this.price = 0;
        }

        public override decimal GetPrice()
        {
            return (100 - discountRate) * BaseComputer.GetPrice() / 100;
        }

        public override string GetOptionCode()
        {
            return base.GetOptionCode() + string.Format("Discount {0}", discountRate);
        }
    }
}
