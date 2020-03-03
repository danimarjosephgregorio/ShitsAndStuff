using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.APIs
{
    public class Television
    {
        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"TV volume set to {volume}");
        }
    }
}
