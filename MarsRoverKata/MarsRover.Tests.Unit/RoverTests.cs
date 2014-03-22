using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Domain;
using MarsRover.Domain.Interfaces;
using NUnit.Framework;

namespace MarsRover.Tests.Unit {
    [TestFixture]
    public class RoverTests {
        [Test]
        public void Rover_implements_the_interface_IRover() {
            var rover = new Rover();

            Assert.IsInstanceOf<IRover>(rover);
        }
    }
}