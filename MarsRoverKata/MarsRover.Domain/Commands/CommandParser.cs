using System;
using System.Collections.Generic;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class CommandParser : ICommandParser {
        private readonly IRover _rover;

        public CommandParser(IRover rover) {
            _rover = rover;
        }

        public IList<IRoverCommand> ParseCommands(string roverCommands) {
            var concreteRoverCommands = new List<IRoverCommand>();
            ParseCommandsAndAddThemToTheListOfCommands(roverCommands, concreteRoverCommands);
            return concreteRoverCommands;
        }

        private void ParseCommandsAndAddThemToTheListOfCommands(string roverCommands, ICollection<IRoverCommand> concreteRoverCommands) {
            for (var i = 0; i < roverCommands.Length; i++) {
                var command = ParseCommand(roverCommands[i].ToString());
                concreteRoverCommands.Add(command);
            }
        }

        private IRoverCommand ParseCommand(string singleRoverCommand) {
            var availableCommands = GetAvailableRoverMovementCommands();
            return availableCommands[singleRoverCommand];
        }

        private Dictionary<string, IRoverCommand> GetAvailableRoverMovementCommands() {
            return new Dictionary<string, IRoverCommand> {
                {"F", new MoveForwardCommand(_rover)},
                {"B", new MoveBackwardCommand(_rover)}
            };
        }
    }
}