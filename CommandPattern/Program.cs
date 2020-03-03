using CommandPattern.APIs;
using CommandPattern.Command;
using CommandPattern.Command.Lights;
using CommandPattern.Command.MacroCommands;
using CommandPattern.Command.TVs;
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
            Television tv = new Television();

            ICommand lightOnCommand = new LightOnCommand(light);
            ICommand lightOffCommand = new LightOffCommand(light);

            ICommand tvOnCommand = new TVOnCommand(tv);
            ICommand tvOffCommand = new TVOffCommand(tv);
            ICommand justWhatEverCommand = new JustWhatEverCommandAvailableCommand(
                new List<ICommand>()
                {
                    lightOnCommand,
                    tvOnCommand
                }    
            );

            remote.SetCommand(lightOnCommand, lightOffCommand, 0);
            remote.SetCommand(tvOnCommand, tvOffCommand, 1);
            remote.SetCommand(justWhatEverCommand, new NoCommand(), 2);

            Console.WriteLine($"{remote.ToString()}");

            remote.OnButtonPress(2);
            remote.OffButtonPress(2);

            Console.ReadLine();
        }
    }
}
