using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.Profile
{
    public class AddressBookPage : ProfilePageBase
    {
        public AddressBookPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<string> Addresses
        {
            get
            {
                var elements = Driver.FindElements(Locators.Addresses);
                return elements.Select(webElement => webElement.Text).ToList().AsReadOnly();
            }
        }

        public string SelectedAddress
        {
            get
            {
                return Driver.ElementDisplayed(Locators.SelectedAddress) ? Driver.FindElement(Locators.SelectedAddress).Text : "";
            }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.AddressesPanel);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By AddressesPanel = By.XPath("//*[@id='addresses']");
            public static By Addresses = By.XPath("//*[@id='addresses']/div/div/div[2]");

            //I am not proud of this.
            public static By SelectedAddress =
                By.XPath("//*[@id='2ef4d145-286e-4c51-a1d4-b958cb387014']/../../../div[2]");
        }
    }
}
