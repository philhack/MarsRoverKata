using System;
using MarsRover.Domain;
using MarsRover.Domain.Interfaces;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsRover.Tests.Acceptance {
    [Binding]
    public class MoveRoverSteps {
        private IRover _rover;
        private IRoverInvoker _roverInvoker;
        private IRoverClient _roverClient;

        [Given(@"The rover is located at ""(.*)""")]
        public void GivenTheRoverIsLocatedAt(string p0) {
            _rover = new Rover();
            _roverInvoker = new RoverInvoker();
            _roverClient = new RoverClient(_rover, _roverInvoker);

            StringAssert.Contains(p0, _rover.CurrentLocation());
        }

        [Given(@"is on a ""(.*)"" grid")]
        public void GivenIsOnAGrid(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"the rover is given the command ""(.*)""")]
        public void WhenTheRoverIsGivenTheCommand(string p0) {
            _roverClient.GiveCommands(p0);
        }

        [Then(@"the rover is at ""(.*)""\.")]
        public void ThenTheRoverIsAt_(string p0) {
            StringAssert.Contains(p0, _rover.CurrentLocation());
        }
    }
}