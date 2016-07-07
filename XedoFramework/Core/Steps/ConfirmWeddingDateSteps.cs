using TechTalk.SpecFlow;
using XedoFramework.Core.Contexts;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class ConfirmWeddingDateSteps : StepBase
    {
        public ConfirmWeddingDateSteps(Context context) : base(context)
        {
        }

        [Given(@"I have chosen a wedding date")]
        public void GivenIHaveChosenAWeddingDate()
        {
            SelectWeddingDatePage.ConfirmWeddingDate();
            SelectWeddingDatePage.Continue();
        }
    }
}
