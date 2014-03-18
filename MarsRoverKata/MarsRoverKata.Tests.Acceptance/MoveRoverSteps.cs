using System;
using TechTalk.SpecFlow;

namespace MarsRoverKata.Tests.Acceptance {
    [Binding]
    public class MoveRoverSteps {
        [Given(@"The rover is located at ""(.*)""")]
        public void GivenTheRoverIsLocatedAt(string p0) {
            ScenarioContext.Current.Pending();
        }

        [Given(@"is on a ""(.*)"" grid")]
        public void GivenIsOnAGrid(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"the rover is given the command ""(.*)""")]
        public void WhenTheRoverIsGivenTheCommand(string p0) {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the rover is at ""(.*)""\.")]
        public void ThenTheRoverIsAt_(string p0) {
            ScenarioContext.Current.Pending();
        }
    }
}