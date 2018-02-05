using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public abstract class Element
    {
        // Accept method accepts a visitor

        public abstract void Accept(IVisitor visitor);
    }
}
