using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Usage
    {
        public void DisplayPattern()
        {
            BigStorePrice price = new BigStorePrice();
            price.ProductPrice = 100;

            PriceWatcher observer1 = new PriceWatcher("Observer 1");
            price.Subscribe(observer1);
            observer1.PriceChanged += observer1_PriceChanged;

            PriceWatcher observer2 = new PriceWatcher("Observer 2");
            price.Subscribe(observer2);
            observer2.PriceChanged += observer2_PriceChanged;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Current price : " + price.ProductPrice);
                Console.Write("Enter new price : ");

                price.ProductPrice = Convert.ToDecimal(Console.ReadLine());
            }
        }

        private void observer2_PriceChanged(object sender, decimal e)
        {
            Console.WriteLine(((PriceWatcher)sender).Name + ": " + e);
        }

        private void observer1_PriceChanged(object sender, decimal e)
        {
            Console.WriteLine(((PriceWatcher)sender).Name + ": " + e);
        }
    }
}
