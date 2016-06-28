using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages
{
    public class NewMemberRegistrationPage : PageBase
    {
        public NewMemberRegistrationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement FirstNameInputBox
        {
            get { return Driver.FindElement(Locators.FirstNameInputBox); }
        }

        public IWebElement LastNameInputBox
        {
            get { return Driver.FindElement(Locators.LastNameInputBox); }
        }

        public IWebElement EmailAddressInputBox
        {
            get { return Driver.FindElement(Locators.EmailAddressInputBox); }
        }

        public IWebElement PasswordInputBox
        {
            get { return Driver.FindElement(Locators.PasswordInputBox); }
        }

        public IWebElement ConfirmPasswordInputBox
        {
            get { return Driver.FindElement(Locators.ConfirmPasswordInputBox); }
        }

        public IWebElement CompleteRegistrationButton
        {
            get { return Driver.FindElement(Locators.CompleteRegistrationButton); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.FirstNameInputBox);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By FirstNameInputBox = By.Id("MemberDetails_FirstName");
            public static By LastNameInputBox = By.Id("MemberDetails_Surname");
            public static By EmailAddressInputBox = By.Id("MemberDetails_Email");
            public static By PasswordInputBox = By.Id("Password_Password");
            public static By ConfirmPasswordInputBox = By.Id("Password_ConfirmPassword");

            public static By CompleteRegistrationButton = By.XPath("//button[contains(@data-galabel, 'complete-registration')]");
        }
    }
}
