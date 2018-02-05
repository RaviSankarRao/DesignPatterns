using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template
{
    public class Usage
    {
        public void DisplayPattern()
        {
            FileDataLogger fileLogger = new FileDataLogger();
            WindowsEventLogger windowsLogger = new WindowsEventLogger();

            while(true)
            {
                Console.Write("Enter Message to log  : ");
                string message = Console.ReadLine();

                fileLogger.LogData(message);
                windowsLogger.LogData(message);
            }
        }
    }
}
