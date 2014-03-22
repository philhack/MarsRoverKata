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
            IList<IRoverCommand> concreteRoverCommands = new List<IRoverCommand>();
            if(roverCommands.StartsWith("F"))
                concreteRoverCommands.Add(new MoveForwardRoverCommand(_rover));
            return concreteRoverCommands;
        }
    }
}