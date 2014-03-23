namespace MarsRover.Domain.Interfaces {
    public interface IPlanetSurface {
        void MoveYCoordinateForward();
        void MoveXCoordinateForward();
        int Xcoordinate { get; }
        int Ycoordinate { get; }
        void MoveYCoordinateBackward();
    }
}