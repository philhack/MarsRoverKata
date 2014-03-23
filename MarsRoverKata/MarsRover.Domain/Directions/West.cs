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
            throw new NotImplementedException();
        }

        public void MoveBackward() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "W";
        }
    }
}