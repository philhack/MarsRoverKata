using System.Collections.Generic;
using MarsRover.Domain.Commands;

namespace MarsRover.Domain.Interfaces {
    public interface IRoverInvoker {
        void AddCommands(IList<IRoverCommand> roverCommands);
        void Execute();
    }
}