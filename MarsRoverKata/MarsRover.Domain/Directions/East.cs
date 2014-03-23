using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class East : IDirection {
        public IDirection TurnRight() {
            return new South();
        }

        public IDirection TurnLeft() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            return "E";
        }
    }
}