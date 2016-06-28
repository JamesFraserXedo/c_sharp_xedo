using System;
using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement MainImageContent
        {
            get { return Driver.FindElement(Locators.MainImageContent); }
        }

        public override bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public class Locators
        {
            public static readonly By MainImageContent = By.Id("hp-hero-Image");
            
        }
    }
}
