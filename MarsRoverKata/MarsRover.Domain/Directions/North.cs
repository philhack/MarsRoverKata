using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class North : IDirection {
        public IDirection TurnRight() {
            return new East();
        }

        public IDirection TurnLeft() {
            return new West();
        }

        public override string ToString() {
            return "N";
        }
    }
}