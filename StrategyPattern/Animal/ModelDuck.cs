using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Animal
{
    class ModelDuck : Duck
    {
        public ModelDuck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy)
        {
            this.flyStrategy = flyStrategy;
            this.quackStrategy = quackStrategy;
        }
    }
}
