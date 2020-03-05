using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class DuckCall : IQuackable
    {
        IQuackObservable observable;

        public DuckCall()
        {
            this.observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
