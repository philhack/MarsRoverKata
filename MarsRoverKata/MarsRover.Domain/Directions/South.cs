using MarsRover.Domain.Interfaces;

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
            PlanetSurface.MoveYCoordinateBackward();
        }

        public void MoveBackward() {
            PlanetSurface.MoveYCoordinateForward();
        }

        public override string ToString() {
            return "S";
        }
    }
}