using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class CreditVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            User user = element as User;
            user.Credits += 50;

        }
    }
}
