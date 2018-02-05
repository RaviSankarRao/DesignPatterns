using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    // Terminal type expression

    public class ValueExpression : Expression
    {
        private string context;

        public ValueExpression(string context)
        {
            this.context = context;
        }

        public override bool Interpret()
        {
            double value;

            if(double.TryParse(context, out value))
            {
                return value != 0;
            }

            return !string.IsNullOrEmpty(context);
        }
    }
}
