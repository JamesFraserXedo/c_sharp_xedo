using System;
using System.Threading;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.QuickTryOn
{
    public class TryOnPopup : ControlBase
    {
        public TryOnPopup(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement DismissButton
        {
            get { return Driver.FindElement(Container, Locators.DismissButton); }
        }

        public void Dismiss()
        {
            if (Driver.ElementDisplayed(Locators.DismissButton))
            { 
                DismissButton.Click();
            }
        }

        public class Locators
        {
            public static By Container = By.XPath("//*[@class='pop-up-container']");
            public static By DismissButton = By.Id("close-legacy-try-on-popup");
        }
    }
}
