using CommandPattern.APIs;
using CommandPattern.Command;
using CommandPattern.Command.Lights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();

            ICommand lightOnCommand = new LightOnCommand(light);
            ICommand lightOffCommand = new LightOffCommand(light);

            remote.SetCommand(lightOnCommand, lightOffCommand, 0);

            Console.WriteLine($"{remote.ToString()}");
            remote.OnButtonPress(0);
            remote.OffButtonPress(0);

            Console.ReadLine();
        }
    }
}
