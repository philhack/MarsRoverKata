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
    public class RoverInvokerTests {
        [Test]
        public void RoverInvoker_implements_the_interface_IRoverInvoker() {
            var roverInvoker = new RoverInvoker();

            Assert.IsInstanceOf<IRoverInvoker>(roverInvoker);
        }
    }
}