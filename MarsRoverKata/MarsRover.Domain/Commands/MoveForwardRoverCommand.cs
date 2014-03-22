using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class MoveForwardRoverCommand : IRoverCommand {
        private IRover _rover;

        public MoveForwardRoverCommand(IRover rover) {
            _rover = rover;
        }

        public void Execute() {
            _rover.MoveForward();
        }
    }
}