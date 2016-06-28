using System;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class LogInSteps : StepBase
    {
        [Given(@"I am logged on to the site")]
        public void GivenIAmLoggedOnToTheSite()
        {
            var email = string.Format("selenium_tester_xedo_{0}@notanemail.com", DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss"));
            var password = "Password";

            CurrentCommonContext.CreatedMemberEmail = email;
            CurrentCommonContext.CreatedMemberPassword = password;

            LoginForm.Expand();
            LoginForm.RegisterLink.Click();
            NewMemberRegistrationPage.FirstNameInputBox.SendKeys("Selenium");
            NewMemberRegistrationPage.LastNameInputBox.SendKeys("Tester");
            NewMemberRegistrationPage.EmailAddressInputBox.SendKeys(email);
            NewMemberRegistrationPage.PasswordInputBox.SendKeys("Password");
            NewMemberRegistrationPage.ConfirmPasswordInputBox.SendKeys("Password");
            NewMemberRegistrationPage.CompleteRegistrationButton.Click();
            //Should automatically redirect to original page
        }
    }
}
