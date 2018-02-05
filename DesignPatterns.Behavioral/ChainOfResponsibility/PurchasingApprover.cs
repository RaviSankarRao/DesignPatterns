using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    // Appoves upto a budget limit

    public class PurchasingApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if(material.Budget < 10000)
            {
                // purchasing can approve anything under 10k
                reason = "Approved by Purchasing";
                return true;
            }
            else if(material.Budget < 100000)
            {
                // for upto 100k, finance needs to approve
                if(nextApprover != null)
                {
                    nextApprover.ApproveMaterial(material, ref reason);
                }

                reason = "Approved by Purchasing";
                return true;
            }
            else
            {
                reason = "Purchasing Rejected : This is way too much. Find another way!";
                return false;
            }
        }
    }
}
