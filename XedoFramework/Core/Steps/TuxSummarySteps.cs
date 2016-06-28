using System.Threading;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class TuxSummarySteps : StepBase
    {
        [Then(@"I can test all the summary tech")]
        public void ThenICanTestAllTheSummaryTech()
        {
            OutfitSummaryPage.WaistcoatSummaryObject.Select();
            OutfitSummaryPage.CustomiseTuxButton.Click();
            OutfitBuilderPage.OutfitControls.ExpandControlsButton.Click();
            Thread.Sleep(1000);
        }
    }
}
