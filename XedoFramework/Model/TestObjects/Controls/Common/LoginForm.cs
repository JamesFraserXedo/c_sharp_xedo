using System;
using System.Threading;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.Common
{
    public class LoginForm : ControlBase
    {
        private Header.Header Header;

        public LoginForm(TestSettings testSettings) : base(testSettings) {
            Header = new Header.Header(testSettings);
        }
        
        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement DismissButton
        {
            get { return Driver.FindElement(Container, Locators.DismissButton); }
        }
        
        public IWebElement LoginBoxMessage
        {
            get { return Driver.FindElement(Container, Locators.LoginBoxMessage); }
        }

        public IWebElement EmailInputBox
        {
            get { return Driver.FindElement(Container, Locators.EmailInputBox); }
        }

        public IWebElement PasswordInputBox
        {
            get { return Driver.FindElement(Container, Locators.PasswordInputBox); }
        }

        public IWebElement TogglePasswordHiddenButton
        {
            get { return Driver.FindElement(Container, Locators.TogglePasswordHiddenButton); }
        }

        public IWebElement ForgottenPasswordLink
        {
            get { return Driver.FindElement(Container, Locators.ForgottenPasswordLink); }
        }

        public IWebElement LoginButton
        {
            get { return Driver.FindElement(Container, Locators.LoginButton); }
        }

        public IWebElement RegisterLink
        {
            get { return Driver.FindElement(Container, Locators.RegisterLink); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Locators.Container); }
        }

        public void Expand()
        {
            if (!Expanded)
            {
                Header.OpenLoginPanelButton.Click();
            }
        }

        public void Close()
        {
            if (Expanded)
            {
                DismissButton.Click();
            }
        }

        public string LoginBoxMessageText
        {
            get { return LoginBoxMessage.Text; }
        }

        public void ClearEmailInputBox()
        {
            EmailInputBox.Clear();
        }

        public void InputEmail(string email)
        {
            EmailInputBox.Click();
            ClearEmailInputBox();
            EmailInputBox.SendKeys(email);
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
            LoginButton.Click();
        }

        //ToDo: Cleanup sleep
        public void Login()
        {
            Expand();
            InputEmail("littlebobbytables@notanemail.com");
            InputPassword("Password");
            Submit();
            Thread.Sleep(5000);
        }

        public void WaitUntilStable()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static readonly By Container = By.XPath("//div[@class='signin-wrapper panel-equalize']");
            public static readonly By DismissButton = By.Id("signin-close-button");
            public static readonly By LoginBoxMessage = By.XPath("//p[@class='right-side-nav-header']");
            public static readonly By EmailInputBox = By.Id("login-username");
            public static readonly By PasswordInputBox = By.Id("login-password");
            public static readonly By TogglePasswordHiddenButton = By.XPath("//button[contains(@class, 'main-password-toggle hideShowPassword-toggle')]");
            public static readonly By ForgottenPasswordLink = By.Id("login-forgot-password");
            public static readonly By LoginButton = By.XPath("//button[contains(text(), 'Login')]");
            public static readonly By RegisterLink = By.XPath("//*[@class='register-link ga-event-click']");
            
        }
    }
}
