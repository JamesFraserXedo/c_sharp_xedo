using OpenQA.Selenium;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.QuickTryOn;

namespace XedoFramework.Model.TestObjects.Pages
{
    public class QuickTryOnPage : PageBase
    {
        public QuickTryOnPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement ReviewAndConfirmTryOnButton
        {
            get { return Driver.FindElement(Locators.ReviewAndConfirmTryOnButton); }
        }

        public InfoForm InfoForm
        {
            get { return new InfoForm(TestSettings); }
        }

        public ColourSelect ColourSelect
        {
            get { return new ColourSelect(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return InfoForm.Container.Displayed;
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(Urls.Xedo.QuickTryOnPage);
        }

        public void PlaceOrder()
        {
            ReviewAndConfirmTryOnButton.Click();
        }

        public class Locators
        {
            public static By ReviewAndConfirmTryOnButton = By.XPath("//*[@data-galabel='quick-try-on-confirm']");
        }
    }
}
