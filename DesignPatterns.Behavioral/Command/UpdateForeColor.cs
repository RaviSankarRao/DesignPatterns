using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class UpdateForeColor : ICommand
    {
        public ConsoleColor Color { get; set; }

        public void UpdateColor()
        {
            Console.ForegroundColor = Color;
        }
    }
}
