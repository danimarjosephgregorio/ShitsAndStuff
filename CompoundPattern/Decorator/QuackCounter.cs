using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class QuackCounter : IQuackable
    {
        private IQuackable duck;
        private static int numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            this.duck.Quack();
            numberOfQuacks++;
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            duck.NotifyObservers();
        }
    }
}
