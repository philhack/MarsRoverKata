using System.Collections.Generic;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class RoverInvoker : IRoverInvoker {
        private IList<IRoverCommand> _roverCommands;

        public void AddCommands(IList<IRoverCommand> roverCommands) {
            _roverCommands = roverCommands;
        }

        public void Execute() {
            foreach (var roverCommand in _roverCommands) {
                roverCommand.Execute();
            }
        }
    }
}