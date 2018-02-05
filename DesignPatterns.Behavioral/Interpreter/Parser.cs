using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Parser
    {
        public Expression Parse(string context)
        {
            List<string> parts = new List<string>(context.Split(' '));

            if(parts.Count < 3)
            {
                return new ValueExpression(context);
            }

            Expression firstExp = new ValueExpression(parts[0]);
            parts.RemoveAt(0);
            return GetNextExpression(parts, firstExp);
        }

        private Expression GetNextExpression(List<string> parts, Expression firstExp)
        {
            if(parts.Count < 2)
            {
                return firstExp;
            }

            Expression secondExp = new ValueExpression(parts[1]);
            string part = parts[0];
            parts.RemoveAt(0);
            parts.RemoveAt(0);

            if(part.ToUpper().Equals("OR"))
            {
                return new OrExpression(firstExp, GetNextExpression(parts, secondExp));
            }
            else
            {
                return new AndExpression(firstExp, GetNextExpression(parts, secondExp));
            }
        }
    }
}
