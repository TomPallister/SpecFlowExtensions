using TechTalk.SpecFlow;

namespace SpecFlowExtension
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.RemoveIfExists("somekey");
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.AddNewRemoveExisting("somekey", new object());
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}