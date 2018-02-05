using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Price
    {
        // the list of observer here is of type abstract class as opposed to concrete classes generally
        List<PriceObserver> observers = new List<PriceObserver>();
        decimal productPrice;

        // Notify - notifies all observer of the price change
        public void Notify()
        {
            foreach (PriceObserver observer in observers)
            {
                observer.Update(this);
            }
        }
        
        
        // Subscribe - adds an observer to the observer collection
        public void Subscribe(PriceObserver observer)
        {
            observers.Add(observer);
        }

        // Unsubscribe - removes an observer from the observer collection
        public void UnSubscribe(PriceObserver observer)
        {
            observers.Remove(observer);
        }

        // Gets or sets price
        public decimal ProductPrice
        {
            get { return productPrice; }
            set
            {
                if(productPrice != value)
                {
                    productPrice = value;
                    Notify();
                }
            }
        }
    }
}
