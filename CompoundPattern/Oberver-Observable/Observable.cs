using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class Observable : IQuackObservable
    {
        ICollection<IQuackObserver> observers = new List<IQuackObserver>();
        IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Notify(duck);
            }
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            observers.Add(observer);
        }
    }
}
