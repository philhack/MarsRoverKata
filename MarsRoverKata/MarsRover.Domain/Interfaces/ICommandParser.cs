using System.Collections.Generic;
using MarsRover.Domain.Commands;

namespace MarsRover.Domain.Interfaces {
    public interface ICommandParser {
        IList<IRoverCommand> ParseCommands(string roverCommands);
    }
}