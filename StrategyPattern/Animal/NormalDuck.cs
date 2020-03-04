using StrategyPattern.Strategy.FlyStrategy;
using StrategyPattern.Strategy.QuackStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Animal
{
    public class NormalDuck : Duck
    {
        public NormalDuck()
        {
            this.flyStrategy = new WingFlyStrategy();
            this.quackStrategy = new NormalQuackStrategy();
        }
    }
}
