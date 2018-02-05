using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        ConsoleColor Color { get; set; }

        // NOTE - the command does not have parameters in it
        // so that invoker need not worry about it during picking this up from the queue if there was one
        void UpdateColor();
    }
}
