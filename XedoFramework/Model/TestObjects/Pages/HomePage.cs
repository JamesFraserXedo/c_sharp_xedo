using System;
using System.Dynamic;
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

        //ToDo
        public override bool IsLoaded()
        {
            return true;
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public void SelectPerfectMatch(string colour)
        {
            Driver.FindElement(Locators.PerfectMatchColour(colour)).Click();
        }

        public class Locators
        {
            public class Common
            {
                
            }

            public static readonly By MainImageContent = By.Id("hp-hero-Image");

            public static By PerfectMatchColour(string colour)
            {
                return
                    By.XPath(string.Format("//*[(@class='colour-display ga-event-click') and (@title='{0}')]", colour));
            }
        }
    }
}
