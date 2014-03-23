using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class South : IDirection {
        public IDirection TurnRight() {
            return new West();
        }

        public IDirection TurnLeft() {
            return new East();
        }

        public override string ToString() {
            return "S";
        }
    }
}