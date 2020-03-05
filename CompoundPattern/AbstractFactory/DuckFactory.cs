using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedHeadDuck()
        {
            return new RedHeadDuck();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
