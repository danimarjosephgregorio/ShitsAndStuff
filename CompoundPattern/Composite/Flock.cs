using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class Flock : IQuackable
    {
        ICollection<IQuackable> quackers = new List<IQuackable>();

        public Flock()
        {

        }

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void NotifyObservers()
        {
        }

        public void Quack()
        {
            foreach (var quacker in quackers)
            {
                quacker.Quack();
            }

            //NotifyObservers();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            foreach (var quacker in quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }
    }
}
