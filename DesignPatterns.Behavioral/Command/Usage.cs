using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Usage
    {
        public void DisplayPattern()
        {
            ActionToUpdateForeColor();
            ActionToUpdateBackColor();
        }

        private void ActionToUpdateBackColor()
        {
            UpdateBackColor backColor = new UpdateBackColor
            {
                Color = ConsoleColor.Blue
            };

            ColorInvoker invoker = new ColorInvoker();
            invoker.Invoke(backColor);
        }

        private void ActionToUpdateForeColor()
        {
            UpdateForeColor foreColor = new UpdateForeColor
            {
                Color = ConsoleColor.Red
            };

            ColorInvoker invoker = new ColorInvoker();
            invoker.Invoke(foreColor);
        }
    }
}
