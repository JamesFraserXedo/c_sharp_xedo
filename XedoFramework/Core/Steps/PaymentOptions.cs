using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class PaymentOptions : StepBase
    {
        [Then(@"the groom should be shown the quoted price")]
        public void ThenTheGroomShouldBeShownTheQuotedPrice()
        {
            Assert.IsTrue(PaymentOptionsPage.GroomTotalDue == CurrentUserJourneyContext.GroomOutfitPrice);
        }

        [Then(@"the groom should get his outfit for free")]
        public void ThenTheGroomShouldGetHisOutfitForFree()
        {
            Assert.IsTrue(PaymentOptionsPage.GroomTotalDue == "$0.00");
        }

    }
}
