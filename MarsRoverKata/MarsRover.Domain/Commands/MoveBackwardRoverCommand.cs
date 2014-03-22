using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class MoveBackwardRoverCommand : IRoverCommand {
        private IRover _rover;

        public MoveBackwardRoverCommand(IRover rover) {
            _rover = rover;
        }

        public void Execute() {
            _rover.MoveBackward();
        }
    }
}