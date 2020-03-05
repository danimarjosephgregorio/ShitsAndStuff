using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedHeadDuck()
        {
            return new QuackCounter(new RedHeadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
