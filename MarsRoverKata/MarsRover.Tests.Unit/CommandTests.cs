using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Domain;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Interfaces;
using NUnit.Framework;

namespace MarsRover.Tests.Unit {
    [TestFixture]
    public class CommandTests {
        IRover _rover;

        [SetUp]
        public void SetUp() {
            _rover = new Rover();
        }

        [Test]
        public void MoveForwardCommand_is_an_instance_of_IRoverCommand() {
            var moveForwardCommand = new MoveForwardRoverCommand(_rover);
            Assert.IsInstanceOf<IRoverCommand>(moveForwardCommand);
        }

        [Test]
        public void MoveBackwardCommand_is_an_instance_of_IRoverCommand() {
            var moveBackwardCommand = new MoveBackwardRoverCommand(_rover);
            Assert.IsInstanceOf<IRoverCommand>(moveBackwardCommand);
        }
    }
}