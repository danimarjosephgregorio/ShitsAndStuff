using CommandPattern.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command.MacroCommands
{
    class JustWhatEverCommandAvailableCommand : ICommand
    {
        IEnumerable<ICommand> commands;

        public JustWhatEverCommandAvailableCommand(IEnumerable<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commands)
            {
                command.Undo();
            }
        }
    }
}
