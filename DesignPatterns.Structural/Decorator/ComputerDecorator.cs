using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class ComputerDecorator : Computer
    {
        protected Computer BaseComputer = null;

        protected string optionCode = "";
        protected decimal price = 0.0M;

        protected ComputerDecorator(Computer computer)
        {
            BaseComputer = computer;
            Model = computer.Model;
        }


        public override string GetOptionCode()
        {
            return string.Format("{0}-{1}", BaseComputer.GetOptionCode(), optionCode);
        }

        public override decimal GetPrice()
        {
            return BaseComputer.GetPrice() + price;
        }
    }
}
