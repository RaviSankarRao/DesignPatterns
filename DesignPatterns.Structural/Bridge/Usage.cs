using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Usage
    {
        public void sendMessage()
        {
            MessageController controller = new MessageController();

            bool sendEmail = true;

            if(sendEmail)
            {
                controller.SetMessageType(MessageType.Email);
            }
            else
            {
                controller.SetMessageType(MessageType.SMS);
            }

            controller.SendMessage("to", "message content");
        }
    }
}
