using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class North : BaseDirection, IDirection {
        public North(IPlanetSurface planetSurface) : base(planetSurface) {
        }

        public IDirection TurnRight() {
            return new East(PlanetSurface);
        }

        public IDirection TurnLeft() {
            return new West(PlanetSurface);
        }

        public void MoveForward() {
            PlanetSurface.MoveYCoordinateForward();
        }

        public void MoveBackward() {
            PlanetSurface.MoveYCoordinateBackward();
        }

        public override string ToString() {
            return "N";
        }
    }
}