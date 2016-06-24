using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.PaymentConfirmation
{
    internal class CreditCardDetailsForm : ControlBase
    {
        private IWebElement _container;

        public CreditCardDetailsForm(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement VisaCreditRadioButton
        {
            get { return Driver.FindElement(_container, Locators.VisaCreditRadioButton); }
        }

        public IWebElement VisaDebitRadioButton
        {
            get { return Driver.FindElement(_container, Locators.VisaDebitRadioButton); }
        }

        public IWebElement MastercardCreditRadioButton
        {
            get { return Driver.FindElement(_container, Locators.MastercardCreditRadioButton); }
        }

        public IWebElement MastercardDebitRadioButton
        {
            get { return Driver.FindElement(_container, Locators.MastercardDebitRadioButton); }
        }

        public IWebElement AmexCreditRadioButton
        {
            get { return Driver.FindElement(_container, Locators.AmexCreditRadioButton); }
        }

        public IWebElement NameInputBox
        {
            get { return Driver.FindElement(_container, Locators.NameInputBox); }
        }

        public IWebElement CardNumberInputBox
        {
            get { return Driver.FindElement(_container, Locators.CardNumberInputBox); }
        }

        public IWebElement ExpiryDateInputBox
        {
            get { return Driver.FindElement(_container, Locators.ExpiryDateInputBox); }
        }

        public IWebElement SecurityCodeInputBox
        {
            get { return Driver.FindElement(_container, Locators.SecurityCodeInputBox); }
        }

        public IWebElement DefaultCreditCardDetailsButton
        {
            get { return Driver.FindElement(_container, Locators.DefaultCreditCardDetailsButton); }
        }

        public class Locators
        {
            public static By VisaCreditRadioButton = By.Id("visa");
            public static By VisaDebitRadioButton = By.Id("visa-debit");
            public static By MastercardCreditRadioButton = By.Id("mastercard");
            public static By MastercardDebitRadioButton = By.Id("mastercard-debit");
            public static By AmexCreditRadioButton = By.Id("amex-debit");

            public static By NameInputBox = By.Id("CardHolderName");
            public static By CardNumberInputBox = By.Id("CardNumber");
            public static By ExpiryDateInputBox = By.Id("ExpiryDate");
            public static By SecurityCodeInputBox = By.Id("SecurityCode");

            public static By DefaultCreditCardDetailsButton = By.Id("enter-test-details");
        }
    }
}
