using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    // Looks for part numbers and drawing numbers

    public class EngineeringApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            bool isValid = true;

            if(string.IsNullOrWhiteSpace(material.DrawingNumber))
            {
                isValid = false;
                reason = "Engineering rejected: There is no drawing number";
            }

            if(string.IsNullOrWhiteSpace(material.PartNumber))
            {
                isValid = false;
                reason = "Engineering rejected: There is no part number";
            }

            if(isValid)
            {
                if(nextApprover != null)
                {
                    return nextApprover.ApproveMaterial(material, ref reason);
                }
            }

            return isValid;
        }
    }
}
