using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain {
    public class PlanetSurface : IPlanetSurface {
        private int _xCoordinate;
        private int _yCoordinate;

        public PlanetSurface() {
            _xCoordinate = 0;
            _yCoordinate = 0;
        }

        public int Xcoordinate {
            get { return _xCoordinate; }
        }

        public int Ycoordinate {
            get { return _yCoordinate; }
        }

        public void MoveYCoordinateBackward() {
            MoveRoverBackwardsUnlessItCanNotMoveBackwards();
        }

        public void MoveYCoordinateForward() {
            _yCoordinate += 1;
        }

        public void MoveXCoordinateForward() {
            _xCoordinate += 1;
        }

        private int MoveRoverBackwardsUnlessItCanNotMoveBackwards() {
            return _yCoordinate >= 1 ? (_yCoordinate -= 1) : 0;
        }
    }
}