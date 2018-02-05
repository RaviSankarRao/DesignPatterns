using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class ColorInvoker
    {
        public void Invoke(ICommand command)
        {
            command.UpdateColor();
        }
    }
}
