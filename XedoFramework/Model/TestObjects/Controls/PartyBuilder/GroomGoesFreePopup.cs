using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.PartyBuilder
{
    public class GroomGoesFreePopup : ControlBase
    {
        public GroomGoesFreePopup(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement NoThanksButton
        {
            get { return Driver.FindElement(Container, Locators.NoThanksButton); }
        }

        public class Locators
        {
            public static By Container = By.Id("GGFDiscountPromptPopup");
            public static By NoThanksButton = By.Id("buildPartyGGFPopUpNoThanksBtn");
        }
    }

   
}
