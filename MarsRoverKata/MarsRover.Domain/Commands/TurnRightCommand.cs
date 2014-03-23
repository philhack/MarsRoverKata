using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class TurnRightCommand : IRoverCommand {
        private IRover _rover;

        public TurnRightCommand(IRover rover) {
            _rover = rover;
        }

        public void Execute() {
            _rover.TurnRight();
        }
    }
}