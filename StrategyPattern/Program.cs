using StrategyPattern.Animal;
using StrategyPattern.Strategy.FlyStrategy;
using StrategyPattern.Strategy.QuackStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck robotDuck = new RobotDuck();
            robotDuck.Fly();
            robotDuck.Quack();

            Duck normalDuck = new NormalDuck();
            normalDuck.Fly();
            normalDuck.Quack();

            Duck modelDuck = new ModelDuck(new NoFlyStrategy(), new HighPitchQuackStrategy());
            modelDuck.Fly();
            modelDuck.Quack();

            Console.ReadLine();
        }
    }
}
