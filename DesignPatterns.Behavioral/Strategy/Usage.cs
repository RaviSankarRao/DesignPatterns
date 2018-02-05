using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Usage
    {
        public void DisplayPattern()
        {
            while(true)
            {
                Console.WriteLine();
                Console.Write("Enter amount : ");
                decimal saleAmount = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Select discount strategy");
                Console.WriteLine("1 for No Discount");
                Console.WriteLine("2 for Student Discount");
                Console.WriteLine("3 for Loyalty Discount");
                Console.WriteLine("4 for Loyal Student Discount");

                int option = Convert.ToInt32(Console.ReadLine());

                Customer customer = new Customer();

                switch(option)
                {
                    case 1:
                        customer.SetDiscountStrategy(new NoDiscount());
                        break;
                    case 2:
                        customer.SetDiscountStrategy(new StudentDiscount());
                        break;
                    case 3:
                        customer.SetDiscountStrategy(new LoyaltyDiscount());
                        break;
                    case 4:
                        customer.SetDiscountStrategy(new LoyalStudentDiscount());
                        break;
                }

                decimal discountedPrice = customer.ApplyDiscount(saleAmount);
                Console.WriteLine("Discounted price : {0}", discountedPrice);
            }
        }
    }
}
