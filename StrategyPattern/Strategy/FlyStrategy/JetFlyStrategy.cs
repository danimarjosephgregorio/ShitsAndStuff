using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.FlyStrategy
{
    public class JetFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Flying with jet pack");
        }
    }
}
