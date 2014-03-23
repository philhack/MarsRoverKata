using System.Collections.Generic;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class RoverClient : IRoverClient {
        private readonly IRover _rover;
        private readonly IRoverInvoker _roverInvoker;

        public RoverClient(IRover rover, IRoverInvoker roverInvoker) {
            _rover = rover;
            _roverInvoker = roverInvoker;
        }

        public void GiveCommands(string roverCommands) {
            var commandParser = new CommandParser(_rover);
            var commands = commandParser.ParseCommands(roverCommands);
            _roverInvoker.AddCommands(commands);
        }

        public string RoversCurrentLocation() {
            throw new System.NotImplementedException();
        }
    }
}