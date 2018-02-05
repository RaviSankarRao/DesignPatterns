using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver nextApprover;

        public void SetNextApprover(Approver nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        public abstract bool ApproveMaterial(Material material, ref string reason);
    }
}
