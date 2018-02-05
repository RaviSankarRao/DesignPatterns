using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Usage
    {
        public void DisplayPattern()
        {
            while(true)
            {
                Console.Write("Enter expression : ");

                string context = Console.ReadLine();

                Parser parser = new Parser();
                Expression expression = parser.Parse(context);

                var result = expression.Interpret();

                Console.WriteLine("Result : {0}", result);
                Console.WriteLine();
            }
        }
    }
}
