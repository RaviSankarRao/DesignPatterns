using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        List<Colleague> colleagues { get; }

        // each colleague registers it with the mediator to add itself to the collection of colleagues the mediator stores
        void Resgiter(Colleague colleague);

        // handled by mediator and passess along to all the colleagues collection held by the mediator
        void PostMessage(Colleague sender, string message);

    }
}
