using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Controls.PartyBuilder;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class BuildPartySteps : StepBase
    {
        [When(@"I add (.*) additional party members")]
        public void WhenIAddAdditionalPartyMembers(int num)
        {
            for (var i = 0; i < num; i++)
            {
                BuildPartyPage.AddPartyMemberButton.Click();
                Thread.Sleep(1000);
                BuildPartyPage.NewPartyMemberPopup.RoleSelect.SelectByText("Groomsman");
                BuildPartyPage.NewPartyMemberPopup.FirstNameInputBox.SendKeys("First");
                BuildPartyPage.NewPartyMemberPopup.LastNameInputBox.SendKeys("Last");
                BuildPartyPage.NewPartyMemberPopup.OutfitSelect.SelectByIndex(1);
                BuildPartyPage.NewPartyMemberPopup.Submit();
            }
        }

        [When(@"I continue to payment")]
        public void WhenIContinueToPayment()
        {
            BuildPartyPage.ContinueToBillingAddress();
            Thread.Sleep(1000);
            if (Driver.ElementDisplayed(GroomGoesFreePopup.Locators.Container))
            {
                GroomGoesFreePopup.NoThanksButton.Click();
                Driver.WaitForElementToDisappear(GroomGoesFreePopup.Locators.Container);
            }
        }
    }
}
