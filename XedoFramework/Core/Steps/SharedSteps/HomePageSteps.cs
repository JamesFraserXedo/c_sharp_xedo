using System;
using System.Drawing;
using XedoFramework.Core.Contexts;
using XedoFramework.Core.Steps.StepsSupport;
using TechTalk.SpecFlow;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class HomePageSteps : StepBase
    {
        public HomePageSteps(Context context) : base(context)
        {
        }

        [When(@"I select the perfect match colour black")]
        public void WhenISelectThePerfectMatchColourBlack()
        {
            HomePage.PerfectMatchSelector.Black.Click();
        }

        [When(@"I select the perfect match colour teal")]
        public void WhenISelectThePerfectMatchColourTeal()
        {
            HomePage.PerfectMatchSelector.Teal.Click();
        }

        [When(@"I select the perfect match colour blue")]
        public void WhenISelectThePerfectMatchColourBlue()
        {
            HomePage.PerfectMatchSelector.Blue.Click();
        }
        
        [When(@"I select the perfect match colour green")]
        public void WhenISelectThePerfectMatchColourGreen()
        {
            HomePage.PerfectMatchSelector.Green.Click();
        }

        [When(@"I select the perfect match colour purple")]
        public void WhenISelectThePerfectMatchColourPurple()
        {
            HomePage.PerfectMatchSelector.Purple.Click();
        }

        [When(@"I select the perfect match colour gray")]
        [When(@"I select the perfect match colour grey")]
        public void WhenISelectThePerfectMatchColourGrey()
        {
            HomePage.PerfectMatchSelector.Grey.Click();
        }

        [When(@"I select the perfect match colour red")]
        public void WhenISelectThePerfectMatchColourRed()
        {
            HomePage.PerfectMatchSelector.Red.Click();
        }

        [When(@"I select the perfect match colour tan")]
        public void WhenISelectThePerfectMatchColourTan()
        {
            HomePage.PerfectMatchSelector.Tan.Click();
        }

        [When(@"I select the perfect match colour pink")]
        public void WhenISelectThePerfectMatchColourPink()
        {
            HomePage.PerfectMatchSelector.Pink.Click();
        }

        [When(@"I select the perfect match colour yellow")]
        public void WhenISelectThePerfectMatchColourYellow()
        {
            HomePage.PerfectMatchSelector.Yellow.Click();
        }

        [When(@"I select the perfect match colour ivory")]
        public void WhenISelectThePerfectMatchColourIvory()
        {
            HomePage.PerfectMatchSelector.Ivory.Click();
        }
    }
}
