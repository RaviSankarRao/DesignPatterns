using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class EmailMessage : IMessage
    {
        public void SendMessage(string to, string message)
        {
            // send an email
        }
    }
}
