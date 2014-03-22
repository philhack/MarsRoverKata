using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class MoveBackwardCommand : IRoverCommand {
        private readonly IRover _rover;

        public MoveBackwardCommand(IRover rover) {
            _rover = rover;
        }

        public void Execute() {
            _rover.MoveBackward();
        }
    }
}