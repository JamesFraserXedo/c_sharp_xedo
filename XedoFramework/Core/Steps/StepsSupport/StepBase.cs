using OpenQA.Selenium;
using TechTalk.SpecFlow;
using XedoFramework.TestObjects.Bases;
using XedoFramework.TestObjects.Controls;
using XedoFramework.TestObjects.Controls.Common;
using XedoFramework.TestObjects.Pages;

namespace XedoFramework.Core.Steps.StepsSupport
{
    [Binding]
    public class StepBase : TechTalk.SpecFlow.Steps
    {
        protected static IWebDriver Driver;
        protected static TestSettings GetTestSettings()
        {
            return new TestSettings(Driver);
        }

        public static HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }

        public static LoginForm LoginForm 
        {
            get { return new LoginForm(GetTestSettings()); }
        }

        public static Header Header
        {
            get { return new Header(GetTestSettings()); }
        }

        public static Footer Footer
        {
            get { return new Footer(GetTestSettings()); }
        }


    }
}
