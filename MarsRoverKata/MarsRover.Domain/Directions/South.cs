using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class South : IDirection {
        public IDirection TurnRight() {
            throw new System.NotImplementedException();
        }

        public IDirection TurnLeft() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            return "S";
        }
    }
}