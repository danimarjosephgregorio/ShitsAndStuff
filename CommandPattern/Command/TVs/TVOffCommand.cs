using CommandPattern.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command.TVs
{
    public class TVOffCommand : ICommand
    {
        Television tv;

        public TVOffCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.Off();
        }

        public void Undo()
        {
            tv.On();
            tv.SetVolume(5);
        }
    }
}
