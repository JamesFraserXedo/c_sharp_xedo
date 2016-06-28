using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.Profile
{
    public class ProfilePage : ProfilePageBase
    {
        public ProfilePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.MemberDetailsForm);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By MemberDetailsForm = By.XPath("//div[@class='form-default-holder']");
        }
    }
}
