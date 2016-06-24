using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.QuickTryOn;

namespace XedoFramework.Model.TestObjects.Controls.PaymentConfirmation
{
    class PaymentForm : ControlBase
    {
        public PaymentForm(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(ColourSelect.Locators.Container); }
        }

        public CreditCardDetailsForm CreditCardDetailsForm
        {
            get { return new CreditCardDetailsForm(TestSettings, Driver.FindElement(Container, Locators.CreditCardDetailsForm)); }
        }

        public BillingAddressForm BillingAddressForm
        {
            get { return new BillingAddressForm(TestSettings, Driver.FindElement(Container, Locators.BillingAddressForm)); }
        }

        public PaymentSummary PaymentSummary
        {
            get { return new PaymentSummary(TestSettings, Driver.FindElement(Container, Locators.PaymentSummary)); }
        }

        public class Locators
        {
            public static By Container = By.XPath(".//*[@id='nab-form']//div[@class='container']");
            public static By CreditCardDetailsForm = By.XPath("//div[@class='form-default-holder'][1]");
            public static By BillingAddressForm = By.XPath("//div[@class='form-default-holder'][2]");
            public static By PaymentSummary = By.XPath("//div[@class='form-default-holder'][3]");
        }
    }
}
