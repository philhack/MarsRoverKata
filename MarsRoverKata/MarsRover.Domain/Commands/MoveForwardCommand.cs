using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class MoveForwardCommand : IRoverCommand {
        private readonly IRover _rover;

        public MoveForwardCommand(IRover rover) {
            _rover = rover;
        }

        public void Execute() {
            _rover.MoveForward();
        }
    }
}