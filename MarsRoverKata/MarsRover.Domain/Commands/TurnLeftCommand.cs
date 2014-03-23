using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Commands {
    public class TurnLeftCommand : IRoverCommand {
        private IRover _rover;

        public TurnLeftCommand(IRover rover) {
            _rover = rover;
        }

        public void Execute() {
            _rover.TurnLeft();
        }
    }
}