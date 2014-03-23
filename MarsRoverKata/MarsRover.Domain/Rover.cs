using System;
using MarsRover.Domain.Directions;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class Rover : IRover {
        private string _currentLocation;
        private IDirection _direction;
        private IPlanetSurface _planetSurface;

        public Rover(IPlanetSurface planetSurface) {
            _planetSurface = planetSurface;
            _direction = new North(_planetSurface);
        }

        public string CurrentLocation() {
            return String.Format("{0},{1},{2}", _planetSurface.Xcoordinate, _planetSurface.Ycoordinate, _direction.ToString());
        }

        public void MoveForward() {
            _direction.MoveForward();
        }

        public void MoveBackward() {
            _direction.MoveBackward();
        }

        public void TurnRight() {
            _direction = _direction.TurnRight();
        }

        public void TurnLeft() {
            _direction = _direction.TurnLeft();
        }
    }
}