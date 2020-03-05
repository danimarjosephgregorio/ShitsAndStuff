using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class GooseAdapter : IQuackable
    {
        Goose goose;
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }

        public void Quack()
        {
            goose.Honk();
        }

        public void RegisterObserver(IQuackObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
