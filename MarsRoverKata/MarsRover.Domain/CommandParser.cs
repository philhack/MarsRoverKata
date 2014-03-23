using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class CommandParser : ICommandParser {
        private readonly IRover _rover;
        private Dictionary<string, IRoverCommand> _availableCommands;

        public CommandParser(IRover rover) {
            _rover = rover;
            LoadRoverCommands();
        }

        public IList<IRoverCommand> ParseCommands(string roverCommands) {
            var concreteRoverCommands = new List<IRoverCommand>();
            ParseCommandsAndAddThemToTheListOfCommands(roverCommands, concreteRoverCommands);
            return concreteRoverCommands;
        }

        private void ParseCommandsAndAddThemToTheListOfCommands(string roverCommands,
                                                                ICollection<IRoverCommand> concreteRoverCommands) {
            for (var i = 0; i < roverCommands.Length; i++) {
                var command = ParseCommand(roverCommands[i].ToString());
                concreteRoverCommands.Add(command);
            }
        }

        private IRoverCommand ParseCommand(string singleRoverCommand) {
            return _availableCommands[singleRoverCommand];
        }

        private void LoadRoverCommands() {
            _availableCommands = new Dictionary<string, IRoverCommand>();
            var commands =
                Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => t.Namespace.Contains("MarsRover.Domain.Commands"));

            foreach (var command in commands) {
                var commandInstance = Activator.CreateInstance(command, _rover) as IRoverCommand;
                _availableCommands.Add(command.Name[4].ToString(), commandInstance);
            }
        }
    }
}