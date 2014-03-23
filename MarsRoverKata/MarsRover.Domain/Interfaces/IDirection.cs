namespace MarsRover.Domain.Interfaces {
    public interface IDirection {
        IDirection TurnRight();
        IDirection TurnLeft();
        void MoveForward();
        void MoveBackward();
    }
}