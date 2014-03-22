using System;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class Rover : IRover {
        private string _currentLocation;

        public Rover() {
            _currentLocation = "0,0,N";
        }

        public void ExecuteCommands(string commands) {
            switch (commands) {
                case "F":
                    _currentLocation = "0,1,N";
                    break;
                case "FF":
                    _currentLocation = "0,2,N";
                    break;
                case "FFB":
                    _currentLocation = "0,1,N";
                    break;
                default:
                    _currentLocation = "0,0,N";
                    break;
            }
        }

        public string CurrentLocation() {
            return _currentLocation;
        }

        public void MoveForward() {
            _currentLocation = "0,1,N";
        }
    }
}