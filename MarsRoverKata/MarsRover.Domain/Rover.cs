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

        public string CurrentLocation() {
            return String.Format("{0},{1},{2}", _xCoordinate, _yCoordinate, _direction);
        }

        public void MoveForward() {
            _yCoordinate += 1;
        }

        public void MoveBackward() {
            _yCoordinate = MoveRoverBackwardsUnlessItCanNotMoveBackwards();
        }

        public void TurnRight() {
            _direction = "E";
        }

        private int MoveRoverBackwardsUnlessItCanNotMoveBackwards() {
            return _yCoordinate >= 1 ? (_yCoordinate - 1) : 0;
        }
    }
}