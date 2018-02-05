using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Usage
    {
        public void DisplayPattern()
        {
            Colleague colleagueBob = new Colleague("Bob");
            Colleague colleagueSue = new Colleague("Sue");
            Colleague colleagueChris = new Colleague("Chris");
            Colleague colleagueDonna = new Colleague("Donna");

            IMediator mediator = new Mediator();

            mediator.Resgiter(colleagueBob);
            mediator.Resgiter(colleagueSue);
            mediator.Resgiter(colleagueChris);

            colleagueBob.SendMessage(mediator, "Hey guys!");

            IMediator mediator2 = new Mediator();
            mediator2.Resgiter(colleagueSue);
            mediator2.Resgiter(colleagueDonna);

            colleagueSue.SendMessage(mediator2, "A more private message");

            colleagueSue.SendMessage(mediator, "A public message");
        }
    }
}
