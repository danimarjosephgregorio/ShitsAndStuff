using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class RedHeadDuck : IQuackable
    {
        IQuackObservable observable;

        public RedHeadDuck()
        {
            this.observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
