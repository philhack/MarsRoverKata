using System;
using MarsRover.Domain;
using MarsRover.Domain.Interfaces;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsRover.Tests.Acceptance {
    [Binding]
    public class MoveRoverSteps {
        private IPlanetSurface _planetSurface;
        private IRoverInvoker _roverInvoker;
        private IRoverClient _roverClient;

        [Given(@"The rover is located at ""(.*)""")]
        public void GivenTheRoverIsLocatedAt(string p0) {
            _planetSurface = new PlanetSurface(100);
            _roverInvoker = new RoverInvoker();
            _roverClient = new RoverClient(_roverInvoker, _planetSurface);

            StringAssert.Contains(p0, _roverClient.RoversCurrentLocation());
        }

        [Given(@"is on a ""(.*)"" grid")]
        public void GivenIsOnAGrid(string p0) {
            var expected = "100x100";

            StringAssert.Contains(expected, _planetSurface.GridSize());
        }

        [When(@"the rover is given the commands ""(.*)""")]
        public void WhenTheRoverIsGivenTheCommands(string p0) {
            _roverClient.GiveCommands(p0);
        }

        [When(@"executes the commands")]
        public void WhenExecutesTheCommands() {
            _roverInvoker.Execute();
        }

        [Then(@"the rover is at ""(.*)""\.")]
        public void ThenTheRoverIsAt_(string p0) {
            StringAssert.Contains(p0, _roverClient.RoversCurrentLocation());
        }
    }
}