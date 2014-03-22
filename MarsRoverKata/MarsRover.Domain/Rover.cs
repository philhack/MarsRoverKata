using System;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class Rover : IRover {
        private string _currentLocation;
        private int _yCoordinate;
        private int _xCoordinate;
        private string _direction;

        public Rover() {
            _xCoordinate = 0;
            _yCoordinate = 0;
            _direction = "N";
        }

        public void ExecuteCommands(string commands) {
            switch (commands) {
                case "F":
                    _yCoordinate += 1;
                    break;
                case "FF":
                    _yCoordinate += 2;
                    break;
                case "FFB":
                    _yCoordinate += 1;
                    break;
            }
        }

        public string CurrentLocation() {
            return String.Format("{0},{1},{2}", _xCoordinate, _yCoordinate, _direction);
        }

        public void MoveForward() {
            _yCoordinate += 1;
        }

        public void MoveBackward() {
            _yCoordinate = MoveRoverBackwardsUnlessItCanNotMoveBackwards();
        }

        private int MoveRoverBackwardsUnlessItCanNotMoveBackwards() {
            return _yCoordinate >= 1 ? (_yCoordinate - 1) : 0;
        }
    }
}