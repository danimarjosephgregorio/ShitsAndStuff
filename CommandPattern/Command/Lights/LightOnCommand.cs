using CommandPattern.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command.Lights
{
    class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = new Light();
        }

        public void Execute()
        {
            light.LightOn();
        }

        public void Undo()
        {
            light.LightOff();
        }
    }
}
