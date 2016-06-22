using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder
{
    public class WelcomePopup : ControlBase
    {
        public WelcomePopup(TestSettings testSettings) : base(testSettings)
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
            public static readonly By Container = By.Id("ob-price-information-popup");
            public static readonly By DismissButton = By.Id("close-info-popup");
        }
    }
}
