using CommandPatternDemo.Command;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternDemo.Invoker
{
    /// <summary>
    /// Invoker Class
    /// </summary>
    class ModifyPrice
    {
        private readonly List<ICommand> _commands;
        private ICommand _command;

        public ModifyPrice()
        {
            _commands = new List<ICommand>();
        }

        /// <summary>
        /// Set Command
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(ICommand command) 
            => _command = command;

        /// <summary>
        /// Execute Command
        /// </summary>
        public void Invoke()
        {
            _commands.Add(_command);
            _command.Execute();
        }

        /// <summary>
        /// Un Execute all commands
        /// </summary>
        public void UndoActions()
        {
            foreach (var command in Enumerable.Reverse(_commands))
            {
                command.UnExecute();
            }
        }
    }
}
