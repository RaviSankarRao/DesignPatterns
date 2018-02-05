using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class PriceObserver
    {
        // Update method is called when Notify method is alled in Price class
        public abstract void Update(Price priceToWatch);
    }
}
