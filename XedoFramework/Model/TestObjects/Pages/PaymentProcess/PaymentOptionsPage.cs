using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.PaymentProcess
{
    public class PaymentOptionsPage : PageBase
    {
        public PaymentOptionsPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public string GroomTotalDue
        {
            get { return Driver.FindElement(Locators.GroomTotalDue).Text; }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Content);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By Content = By.XPath("//*[contains(@class, 'content-section-holder')]");
            public static By GroomTotalDue = By.XPath("//*[@class='total-amount'][1]");
        }
    }
}
