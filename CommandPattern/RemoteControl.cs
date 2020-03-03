using CommandPattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] onCommands = new ICommand[7];
        ICommand[] offCommands = new ICommand[7];

        public RemoteControl()
        {
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(ICommand onCommand, ICommand offCommand, int slot)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonPress(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonPress(int slot)
        {
            offCommands[slot].Execute();
        }

        public override string ToString()
        {
            string remote = string.Empty;

            for (int i = 0; i < onCommands.Length; i++)
            {
                remote += $"Command slot {i}: {onCommands[i].ToString()} || {offCommands[i].ToString()}\n";
            }
            return remote;
        }
    }
}
