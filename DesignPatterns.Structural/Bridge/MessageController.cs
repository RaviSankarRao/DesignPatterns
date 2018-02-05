using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    // the bridge class
    public class MessageController
    {
        private IMessage Message { get; set; }

        public void SetMessageType(MessageType messageType)
        {
            switch(messageType)
            {
                case MessageType.Email:
                    Message = new EmailMessage();
                    break;
                case MessageType.SMS:
                    Message = new SMSMessage();
                    break;
                    
            }
        }

        public void SendMessage(string to, string message)
        {
            Message.SendMessage(to, message);
        }
    }
}
