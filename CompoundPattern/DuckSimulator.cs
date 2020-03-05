using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redHeadDuck = duckFactory.CreateRedHeadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();

            Goose goose = new GooseFactory().CreateGoose();
            IQuackable goosePretendingToBeADuck = new GooseAdapter(goose);

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(redHeadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);

            Flock flockOfMallardDucks = new Flock();
            flockOfMallardDucks.Add(duckFactory.CreateMallardDuck());
            flockOfMallardDucks.Add(duckFactory.CreateMallardDuck());
            flockOfMallardDucks.Add(duckFactory.CreateMallardDuck());
            flockOfMallardDucks.Add(duckFactory.CreateMallardDuck());
            flockOfMallardDucks.Add(duckFactory.CreateMallardDuck());
            flockOfMallardDucks.Add(duckFactory.CreateMallardDuck());

            flockOfDucks.Add(flockOfMallardDucks);

            IQuackObserver quackScientist = new Quackologist();
            flockOfDucks.RegisterObserver(quackScientist);

            Console.WriteLine("\nDuck Simulator:");

            //Console.WriteLine("Flock of mallard ducks: ");
            //Simulate(flockOfMallardDucks);

            Console.WriteLine("\nFlock of all ducks: ");
            Simulate(flockOfDucks);

            Console.WriteLine("\nThe goose pretending to be duck: ");
            Simulate(goosePretendingToBeADuck);

            Console.WriteLine($"\nThe ducks quacked {QuackCounter.GetQuacks()} times");
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
