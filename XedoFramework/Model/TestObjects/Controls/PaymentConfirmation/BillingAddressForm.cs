using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.PaymentConfirmation
{
    class BillingAddressForm : ControlBase
    {
        private IWebElement _container;

        public BillingAddressForm(TestSettings testSettings, IWebElement container)
            : base(testSettings)
        {
            _container = container;
        }

        public IWebElement AddressInputBox
        {
            get { return Driver.FindElement(_container, Locators.AddressInputBox); }
        }

        public IWebElement CityInputBox
        {
            get { return Driver.FindElement(_container, Locators.CityInputBox); }
        }

        public SelectElement StateSelect
        {
            get { return new SelectElement(Driver.FindElement(_container, Locators.StateSelect)); }
        }

        public IWebElement ZipcodeInputBox
        {
            get { return Driver.FindElement(_container, Locators.ZipcodeInputBox); }
        }

        public IWebElement CountryInputBox
        {
            get { return Driver.FindElement(_container, Locators.CountryInputBox); }
        }

        public class Locators
        {
            public static By AddressInputBox = By.Id("Address");
            public static By CityInputBox = By.Id("City");
            public static By StateSelect = By.Id("State");
            public static By ZipcodeInputBox = By.Id("ZipCode");
            public static By CountryInputBox = By.Id("Country");
        }
    }
}
