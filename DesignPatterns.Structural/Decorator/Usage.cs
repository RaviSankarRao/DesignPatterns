using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Usage
    {
        public void displayPattern()
        {
            ComputerBase computer = new ComputerBase
            {
                Model = "Lenovo Thinkpad"
            };

            Console.WriteLine("1. 8 GB RAM or 2. 16 GB RAM");
            int ramOption = Convert.ToInt32(Console.ReadLine());

            ComputerDecorator ramDecorator;
            if(ramOption == 1)
            {
                ramDecorator = new Memory8Option(computer);
            }
            else
            {
                ramDecorator = new Memory16Option(computer);
            }

            Console.WriteLine("SSD - 1. 128 GB or 2. 256 GB or 3. 512 GB");
            int ssdOption = Convert.ToInt32(Console.ReadLine());

            ComputerDecorator ssdDecorator;

            if(ssdOption == 1)
            {
                ssdDecorator = new SSD128Option(ramDecorator);
            }
            else if(ssdOption == 2)
            {
                ssdDecorator = new SSD256Option(ramDecorator);
            }
            else
            {
                ssdDecorator = new SSD512Option(ramDecorator);
            }

            Console.WriteLine("apply discount Y/N");
            string discount = Console.ReadLine();

            ComputerDecorator discountDecorator;
            if(discount == "Y" || discount == "y")
            {
                discountDecorator = new DiscountDecorator(ssdDecorator);
            }
            else
            {
                discountDecorator = ssdDecorator;
            }

            Console.WriteLine("Your order");
            Console.WriteLine("Model - {0} - {1}", discountDecorator.Model , discountDecorator.GetOptionCode());
            Console.WriteLine("Price - {0}", discountDecorator.GetPrice());

        }
    }
}
