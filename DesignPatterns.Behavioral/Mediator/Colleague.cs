using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Colleague
    {
        public string Name { get; set; }

        public Colleague(string name)
        {
            this.Name = name;
        }

        // Send message goes to a mediator. 
        // Not called by any colleague class
        public void SendMessage(IMediator mediator, string message)
        {
            mediator.PostMessage(this, message);
        }

        // Recieve message comes from a mediator
        // Not called by any colleague class
        public void RecieveMessage(string message, string sender)
        {
            Console.WriteLine(Name + ", message from: " + sender + ": " + message);
        }
    }
}
