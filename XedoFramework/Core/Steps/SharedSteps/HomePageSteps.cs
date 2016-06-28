using XedoFramework.Core.Steps.StepsSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class HomePageSteps : StepBase
    {
        [Then(@"The main image content is visible")]
        public void ThenTheMainImageContentIsVisible()
        {
            Assert.IsTrue(HomePage.MainImageContent.Displayed);
        }

    }
}
