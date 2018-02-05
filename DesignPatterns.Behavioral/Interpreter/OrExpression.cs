using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class OrExpression : Expression
    {
        private Expression expression1 = null;
        private Expression expression2 = null;

        public OrExpression(Expression expression1, Expression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public override bool Interpret()
        {
            return expression1.Interpret() || expression2.Interpret();
        }
    }
}
