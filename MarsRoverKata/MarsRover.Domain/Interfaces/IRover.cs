namespace MarsRover.Domain.Interfaces {
    public interface IRover {
        string CurrentLocation();
        void MoveForward();
        void MoveBackward();
        void TurnRight();
    }
}