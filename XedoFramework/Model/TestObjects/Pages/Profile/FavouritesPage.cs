using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.Profile
{
    public class FavouritesPage : ProfilePageBase
    {
        public FavouritesPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.FavouritesPanel);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By FavouritesPanel = By.XPath("//*[@class='control-favourite-area']");
        }
    }
}
