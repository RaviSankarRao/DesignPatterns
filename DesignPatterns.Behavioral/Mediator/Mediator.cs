using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Mediator : IMediator
    {
        private List<Colleague> colleagueList = new List<Colleague>();

        public List<Colleague> colleagues
        {
            get
            {
                return colleagueList;
            }
        }

        public void Resgiter(Colleague colleague)
        {
            colleagueList.Add(colleague);
        }

        public void PostMessage(Colleague sender, string message)
        {
            foreach (var c in colleagueList)
            {
                if(c!= sender)
                {
                    c.RecieveMessage(message, sender.Name);
                }
            }
        }
    }
}
