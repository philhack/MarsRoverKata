using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Domain.Commands;
using NUnit.Framework;

namespace MarsRover.Tests.Unit {
    [TestFixture]
    public class Command_Tests {
        [Test]
        public void MoveForwardCommand_is_an_instance_of_IRoverCommand() {
            var moveForwardCommand = new MoveForwardRoverCommand();
            Assert.IsInstanceOf<IRoverCommand>(moveForwardCommand);
        }

        [Test]
        public void MoveBackwardCommand_is_an_instance_of_IRoverCommand() {
            var moveBackwardCommand = new MoveBackwardRoverCommand();
            Assert.IsInstanceOf<IRoverCommand>(moveBackwardCommand);
        }
    }
}