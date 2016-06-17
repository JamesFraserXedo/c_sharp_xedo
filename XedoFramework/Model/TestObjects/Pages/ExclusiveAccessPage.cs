using OpenQA.Selenium;
using XedoFramework.SupportTools;
using XedoFramework.TestObjects.Bases;

namespace XedoFramework.TestObjects.Pages
{
    public class ExclusiveAccessPage : ControlBase
    {
        public ExclusiveAccessPage(TestSettings testSettings) : base(testSettings)
        {

        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement PasswordInputBox
        {
            get { return Driver.FindElement(Container, Locators.PasswordInputBox); }
        }

        public IWebElement SubmitPasswordButton
        {
            get { return Driver.FindElement(Container, Locators.SubmitPasswordButton); }
        }

        public void ClearPasswordInputBox()
        {
            PasswordInputBox.Clear();
        }

        public void InputPassword(string password)
        {
            PasswordInputBox.Click();
            ClearPasswordInputBox();
            PasswordInputBox.SendKeys(password);
        }

        public void Submit()
        {
            SubmitPasswordButton.Click();
        }

        public class Locators
        {
            public static readonly By Container = By.XPath("//div[@class='password-page-section']");
            public static readonly By PasswordInputBox = By.Id("Password");
            public static readonly By SubmitPasswordButton = By.XPath("//button[@type='submit']");
        }
    }
}
