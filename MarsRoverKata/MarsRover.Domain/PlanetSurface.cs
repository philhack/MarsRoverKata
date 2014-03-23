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
            _yCoordinate = MoveRoverBackwardsOnCoordinateUnlessItCanNotMoveBackwards(_yCoordinate);
        }

        public void MoveXCoordinateBackward() {
            _xCoordinate = MoveRoverBackwardsOnCoordinateUnlessItCanNotMoveBackwards(_xCoordinate);
        }

        public void MoveYCoordinateForward() {
            _yCoordinate += 1;
        }

        public void MoveXCoordinateForward() {
            _xCoordinate += 1;
        }

        private int MoveRoverBackwardsOnCoordinateUnlessItCanNotMoveBackwards(int currentCoodinateValue) {
            return currentCoodinateValue >= 1 ? (currentCoodinateValue - 1) : 0;
        }
    }
}