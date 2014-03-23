using System;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain.Directions {
    public class West : IDirection {
        public IDirection TurnRight() {
            return new North();
        }

        public IDirection TurnLeft() {
            return new South();
        }

        public override string ToString() {
            return "W";
        }
    }
}