using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SMSMessage : IMessage
    {
        public void SendMessage(string to, string message)
        {
            // send SMS
        }
    }
}
