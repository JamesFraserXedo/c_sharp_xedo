using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Pages.PaymentProcess;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class BillingAddressSteps : StepBase
    {
        [When(@"I complete billing")]
        public void WhenICompleteBilling()
        {
            if (Driver.ElementDisplayed(BillingAddressPage.Locators.ConfirmListedAddressButton))
            {
                BillingAddressPage.ConfirmListedAddressButton.Click();
            }
            else
            {
                BillingAddressPage.Address1InputBox.SendKeys("4400 Quality Drive");
                BillingAddressPage.StateInputBox.SendKeys("TN");
                BillingAddressPage.ZipInputBox.SendKeys("30329");
                BillingAddressPage.ConfirmEnteredAddressButton.Click();

                //Driver.WaitForElementToAppear(By.Id("confirm-suggested-address"));
                //Driver.FindElement(By.Id("confirm-suggested-address")).Click();
            }
            BillingAddressPage.ContactNumberInputBox.SendKeys("866-574-6088");
            Thread.Sleep(3000);
            BillingAddressPage.PaymentOptionsButton.Click();
        }
    }
}

        
