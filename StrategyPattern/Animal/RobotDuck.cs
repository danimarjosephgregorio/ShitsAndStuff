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
    public class RobotDuck : Duck
    {
        public RobotDuck()
        {
            this.flyStrategy = new JetFlyStrategy();
            this.quackStrategy = new SyntheticQuackStrategy();
        }
    }
}
