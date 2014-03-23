using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Domain;
using MarsRover.Domain.Commands;
using MarsRover.Domain.Interfaces;
using NUnit.Framework;

namespace Given_a_rover_at_coordinates_0_0_N {
    public class Given_a_rover_at_coordinates_0_0_N {
        protected IRover Rover;
        protected IRoverInvoker RoverInvoker;
        protected IRoverClient RoverClient;
        private IPlanetSurface _planetSurface;

        [SetUp]
        public void Given() {
            _planetSurface = new PlanetSurface();
            Rover = new Rover(_planetSurface);
            RoverInvoker = new RoverInvoker();
            RoverClient = new RoverClient(Rover, RoverInvoker);
        }
    }

    public class When_no_command_is_given : Given_a_rover_at_coordinates_0_0_N {
        [Test]
        public void Then_the_robots_position_is_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_an_empty_command_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("");
        }

        [Test]
        public void Then_the_robots_position_is_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_F_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("F");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rovers_current_location_is_now_at_0_1_N() {
            var expected = "0,1,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }


    public class When_the_commands_FF_are_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("FF");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rovers_current_location_is_now_at_0_2_N() {
            var expected = "0,2,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_B_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("B");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rovers_current_location_is_now_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_commands_BB_are_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("BB");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rovers_current_location_is_now_at_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_commands_FFB_are_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("FFB");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rovers_current_location_is_now_at_0_1_N() {
            var expected = "0,1,N";
            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_R_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("R");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_E() {
            var expected = "0,0,E";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_L_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("L");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_W() {
            var expected = "0,0,W";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RR_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RR");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_S() {
            var expected = "0,0,S";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RRR_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RRR");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_W() {
            var expected = "0,0,W";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RRRR_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RRRR");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_LL_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("LL");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_S() {
            var expected = "0,0,S";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_LLL_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("LLL");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_E() {
            var expected = "0,0,E";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_LLLL_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("LLLL");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_N() {
            var expected = "0,0,N";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RF_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RF");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_1_0_E() {
            var expected = "1,0,E";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RB_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RB");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_E() {
            var expected = "0,0,E";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RFFB_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RFFB");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_0_E() {
            var expected = "1,0,E";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_FFRRF_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("FFRRF");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_1_S() {
            var expected = "0,1,S";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }

    public class When_the_command_RRB_is_given : Given_a_rover_at_coordinates_0_0_N {
        [SetUp]
        public void When() {
            RoverClient.GiveCommands("RRB");
            RoverInvoker.Execute();
        }

        [Test]
        public void Then_the_rover_current_location_is_0_1_S() {
            var expected = "0,1,S";

            Assert.AreEqual(expected, Rover.CurrentLocation());
        }
    }
}