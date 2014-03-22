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
        public void MoveForwardCommand_is_an_instance_of_ICommand() {
            var moveForwardCommand = new MoveForwardCommand();
            Assert.IsInstanceOf<ICommand>(moveForwardCommand);
        }
    }
}