using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class East : BaseDirection, IDirection {
        public East(IPlanetSurface planetSurface) : base(planetSurface) {
        }

        public IDirection TurnRight() {
            return new South(PlanetSurface);
        }

        public IDirection TurnLeft() {
            return new North(PlanetSurface);
        }

        public void MoveForward() {
            PlanetSurface.MoveXCoordinateForward();
        }

        public void MoveBackward() {
            PlanetSurface.MoveXCoordinateBackward();
        }

        public override string ToString() {
            return "E";
        }
    }
}