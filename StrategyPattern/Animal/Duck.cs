using StrategyPattern.Strategy;
using StrategyPattern.Strategy.FlyStrategy;
using StrategyPattern.Strategy.QuackStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Animal
{
    public class Duck
    {
        protected IFlyStrategy flyStrategy;
        protected IQuackStrategy quackStrategy;

        public Duck()
        {
            this.flyStrategy = new WingFlyStrategy();
            this.quackStrategy = new NormalQuackStrategy();
        }

        public void Fly()
        {
            flyStrategy.Fly();
        }

        public void Quack()
        {
            quackStrategy.Quack();
        }
    }
}
