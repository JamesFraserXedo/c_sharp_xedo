using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.PaymentProcess
{
    public class SelectWeddingDatePage : PageBase
    {
        public SelectWeddingDatePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement ConfirmWeddingDateButton
        {
            get { return Driver.FindElement(Locators.ConfirmWeddingDateButton); }
        }

        public IWebElement ContinueButton
        {
            get { return Driver.FindElement(Locators.ContinueButton); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.MainContent);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public void ConfirmWeddingDate()
        {
            ConfirmWeddingDateButton.Click();
        }

        public void Continue()
        {
            ContinueButton.Click();
        }

        public class Locators
        {
            public static By ConfirmWeddingDateButton = By.Id("confirm-wedding-date");
            public static By ContinueButton = By.Id("btn-wedding-date-next");
            public static By MainContent = By.XPath("//*[@class='content-section-holder']");
        }
    }
}
