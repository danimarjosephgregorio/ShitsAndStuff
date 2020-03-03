using CommandPattern.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command.TVs
{
    public class TVOnCommand : ICommand
    {
        Television tv;

        public TVOnCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
            tv.SetVolume(5);
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}
