using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Material
    {
        public string Name { get; set; }

        public Guid MaterialId { get; set; }

        public string PartNumber { get; set; }

        public decimal Budget { get; set; }

        public string DrawingNumber { get; set; }
    }
}
