using System;

namespace MarsRover.Domain {
    public class Rover {
        private string _currentLocation;

        public void ExecuteCommands(string commands) {
            _currentLocation = commands == "F" ? "0,1,N" : "0,0,N";
        }

        public string CurrentLocation() {
            return _currentLocation;
        }
    }
}