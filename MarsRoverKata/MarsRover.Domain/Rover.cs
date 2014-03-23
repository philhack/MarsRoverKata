using System;
using MarsRover.Domain.Directions;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class Rover : IRover {
        private string _currentLocation;
        private int _yCoordinate;
        private int _xCoordinate;
        private IDirection _direction;

        public Rover() {
            _xCoordinate = 0;
            _yCoordinate = 0;
            _direction = new North();
        }

        public string CurrentLocation() {
            return String.Format("{0},{1},{2}", _xCoordinate, _yCoordinate, _direction.ToString());
        }

        public void MoveForward() {
            _yCoordinate += 1;
        }

        public void MoveBackward() {
            _yCoordinate = MoveRoverBackwardsUnlessItCanNotMoveBackwards();
        }

        public void TurnRight() {
            _direction = _direction.TurnRight();
        }

        public void TurnLeft() {
            _direction = _direction.TurnLeft();
        }

        private int MoveRoverBackwardsUnlessItCanNotMoveBackwards() {
            return _yCoordinate >= 1 ? (_yCoordinate - 1) : 0;
        }
    }
}