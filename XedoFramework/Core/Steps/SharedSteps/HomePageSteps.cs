using XedoFramework.Core.Steps.StepsSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class HomePageSteps : StepBase
    {
        [When(@"I select the perfect match colour (.*)")]
        public void WhenISelectThePerfectMatchColour(string colour)
        {
            HomePage.SelectPerfectMatch(colour);
        }
    }
}
