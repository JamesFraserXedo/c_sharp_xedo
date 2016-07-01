using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.PaymentProcess
{
    public class BillingAddressPage : PageBase
    {
        public BillingAddressPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement ConfirmListedAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmListedAddressButton); }
        }

        public IWebElement Address1InputBox
        {
            get { return Driver.FindElement(Container, Locators.Address1InputBox); }
        }

        public IWebElement StateInputBox
        {
            get { return Driver.FindElement(Container, Locators.StateInputBox); }
        }

        public IWebElement ZipInputBox
        {
            get { return Driver.FindElement(Container, Locators.ZipInputBox); }
        }

        public IWebElement ConfirmEnteredAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmEnteredAddressButton); }
        }

        public IWebElement ContactNumberInputBox
        {
            get { return Driver.FindElement(Container, Locators.ContactNumberInputBox); }
        }

        public IWebElement PaymentOptionsButton
        {
            get { return Driver.FindElement(Container, Locators.PaymentOptionsButton); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Container);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By Container = By.XPath("//*[@class='content-section-holder']");
            public static By ConfirmListedAddressButton = By.Id("confirm-address");

            public static By Address1InputBox = By.Id("address1");
            public static By StateInputBox = By.Id("address4");
            public static By ZipInputBox = By.Id("postcode");
            public static By ConfirmEnteredAddressButton = By.Id("confirm-manual-address");

            public static By ContactNumberInputBox = By.Id("ContactNumber");
            public static By PaymentOptionsButton = By.Id("btn-outfit-delivery-next");
        }
    }
}
