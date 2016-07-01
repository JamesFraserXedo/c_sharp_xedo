using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class ConfirmWeddingDateSteps : StepBase
    {
        [Given(@"I have chosen a wedding date")]
        public void GivenIHaveChosenAWeddingDate()
        {
            SelectWeddingDatePage.ConfirmWeddingDate();
            SelectWeddingDatePage.Continue();
        }
    }
}
