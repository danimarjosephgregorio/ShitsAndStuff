using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class RubberDuck : IQuackable
    {
        IQuackObservable observable;

        public RubberDuck()
        {
            this.observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
