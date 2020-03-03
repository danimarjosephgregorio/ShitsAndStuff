using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.APIs
{
    public class Light
    {
        public void LightOn()
        {
            Console.WriteLine("Light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
