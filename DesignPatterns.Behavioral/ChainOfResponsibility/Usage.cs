using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Usage
    {
        public void displayPattern()
        {
            while (true)
            {
                Console.WriteLine();
                Material material = new Material
                {
                    MaterialId = Guid.NewGuid(),
                    Name = "White board",
                    PartNumber = "PRTWHTBRD1",
                    DrawingNumber = "DNWHTBRD1",
                };

                Console.Write("Enter the cost : ");
                material.Budget = Convert.ToDecimal(Console.ReadLine());

                DisplayMaterial(material);

                Approver engApp = new EngineeringApprover();
                Approver purApp = new PurchasingApprover();
                Approver finApp = new FinanceApprover();

                engApp.SetNextApprover(purApp);
                purApp.SetNextApprover(finApp);

                string reason = string.Empty;

                if (engApp.ApproveMaterial(material, ref reason))
                {
                    reason = "Approved. " + reason;
                }
                else
                {
                    reason = "Rejected. " + reason;
                }

                Console.WriteLine("Status : {0}", reason);
            }
        }

        void DisplayMaterial(Material material)
        {
            Console.WriteLine("Material details");
            Console.WriteLine("Name : {0}", material.Name);
            Console.WriteLine("Budget : {0}", material.Budget);
        }
    }
}
