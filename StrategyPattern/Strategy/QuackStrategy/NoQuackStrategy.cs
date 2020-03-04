using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.QuackStrategy
{
    public class NoQuackStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("Cannot quack");
        }
    }
}
