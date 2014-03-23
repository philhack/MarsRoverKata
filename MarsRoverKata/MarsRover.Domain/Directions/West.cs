using System;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class West : BaseDirection, IDirection {
        public West(IPlanetSurface planetSurface) : base(planetSurface) {
        }

        public IDirection TurnRight() {
            return new North(PlanetSurface);
        }

        public IDirection TurnLeft() {
            return new South(PlanetSurface);
        }

        public void MoveForward() {
            PlanetSurface.MoveXCoordinateBackward();
        }

        public void MoveBackward() {
            PlanetSurface.MoveXCoordinateForward();
        }

        public override string ToString() {
            return "W";
        }
    }
}