﻿using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class South : BaseDirection, IDirection {
        public South(IPlanetSurface planetSurface) : base(planetSurface) {
        }

        public IDirection TurnRight() {
            return new West(PlanetSurface);
        }

        public IDirection TurnLeft() {
            return new East(PlanetSurface);
        }

        public void MoveForward() {
            throw new System.NotImplementedException();
        }

        public void MoveBackward() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            return "S";
        }
    }
}