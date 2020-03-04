using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.QuackStrategy
{
    public class HighPitchQuackStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("High pitch quack");
        }
    }
}
