using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    // Approves up to a larger budget limit

    public class FinanceApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if (material.Budget < 100000)
            {
                // for upto 100k, finance needs to approve
                if (nextApprover != null)
                {
                    nextApprover.ApproveMaterial(material, ref reason);
                }

                reason = "Approved by Finance";
                return true;
            }
            else
            {
                reason = "Finance Rejected: This is way too much. Find another way!";
                return false;
            }
        }
    }
}
