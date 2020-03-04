using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.QuackStrategy
{
    public class SyntheticQuackStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("Quack with synthetically made voice");
        }
    }
}
