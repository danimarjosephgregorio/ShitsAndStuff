using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class Quackologist : IQuackObserver
    {
        public void Notify(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: Amazing! {duck} just quacked");
        }
    }
}
