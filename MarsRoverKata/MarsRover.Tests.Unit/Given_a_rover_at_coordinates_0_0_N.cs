using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Domain;
using NUnit.Framework;

namespace Given_a_rover_at_coordinates_0_0_N {
    public class Given_a_rover_at_coordinates_0_0_N {
        protected Rover Rover;

        [SetUp]
        public void Given() {
            Rover = new Rover();
        }
    }

    public class When_no_command_is_given : Given_a_rover_at_coordinates_0_0_N {
        [Test]
        public void Then_the_robots_position_is_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_F_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            Rover.ExecuteCommands("F");
        }

        [Test]
        public void Then_the_robots_position_is_now_at_0_1_N() {
            var expected = "0,1,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_FF_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            Rover.ExecuteCommands("FF");
        }

        [Test]
        public void Then_the_robots_position_is_now_at_0_2_N() {
            var expected = "0,2,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_B_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            Rover.ExecuteCommands("B");
        }

        [Test]
        public void Then_the_robots_position_is_now_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_BB_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            Rover.ExecuteCommands("BB");
        }

        [Test]
        public void Then_the_robots_position_is_now_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_commands_FFB_are_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            Rover.ExecuteCommands("FFB");
        }

        [Test]
        public void Then_the_robots_position_is_now_at_0_1_N() {
            var expected = "0,1,N";
            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }
}