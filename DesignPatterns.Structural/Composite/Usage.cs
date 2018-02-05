using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Usage
    {
        public void displayPattern()
        {
            Assembly main = new Assembly("Main assembly", 1);
            Assembly chassis = new Assembly("Chassis", 1);
            Assembly display = new Assembly("Display", 1);
            Assembly powerSupply = new Assembly("Power Supply", 1);

            Part bolt = new Part("Bolt", 20);
            Part mainCase = new Part("Case", 1);
            Part screen = new Part("Screen", 1);
            Part displayElectronics = new Part("DisplayElectronics", 3);
            Part transformer = new Part("Transformer", 1);
            Part powerBoard = new Part("Power Board", 1);
            Part motherBoard = new Part("Mother Board", 1);

            main.Add(chassis);
            main.Add(display);
            main.Add(powerSupply);

            chassis.Add(mainCase);
            chassis.Add(bolt);

            display.Add(screen);
            display.Add(displayElectronics);

            powerSupply.Add(transformer);
            powerSupply.Add(powerBoard);
            powerSupply.Add(motherBoard);

            DisplayPartList(main);
        }

        void DisplayPartList(Assembly main)
        {
            List<string> partList = new List<string>();
            main.WritePartsList(partList);

            foreach (var item in partList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
