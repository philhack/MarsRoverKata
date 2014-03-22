namespace MarsRover.Domain.Interfaces {
    public interface IRover {
        void ExecuteCommands(string commands);
        string CurrentLocation();
        void MoveForward();
    }
}