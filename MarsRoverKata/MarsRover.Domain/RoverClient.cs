using System.Collections.Generic;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class RoverClient : IRoverClient {
        private readonly IRover _rover;
        private readonly IRoverInvoker _roverInvoker;

        public RoverClient(IRoverInvoker roverInvoker, IPlanetSurface planetSurface) {
            _roverInvoker = roverInvoker;
            _rover = new Rover(planetSurface);
        }

        public void GiveCommands(string roverCommands) {
            var commandParser = new CommandParser(_rover);
            var commands = commandParser.ParseCommands(roverCommands);
            _roverInvoker.AddCommands(commands);
        }

        public string RoversCurrentLocation() {
            return _rover.CurrentLocation();
        }
    }
}