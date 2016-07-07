using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoFramework.Core.Contexts;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps.LoadTimeSteps
{
    [Binding]
    public class CommonLoadTimeSteps : StepBase
    {
        public CommonLoadTimeSteps(Context context) : base(context)
        {
        }

        [Then(@"the page load time will be less than (.*) seconds")]
        public void ThenThePageLoadTimeWillBeLessThanSeconds(int seconds)
        {
            Assert.IsTrue(CurrentContext.LoadTime.PageContentLoadTime < seconds * 1000,
                "Actual load time was " + CurrentContext.LoadTime.PageContentLoadTime + " ms");
        }

    }
}
