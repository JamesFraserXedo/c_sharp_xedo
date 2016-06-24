using OpenQA.Selenium;
using TechTalk.SpecFlow;
using XedoFramework.Core.Contexts;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.Common;
using XedoFramework.Model.TestObjects.Controls.Common.Footer;
using XedoFramework.Model.TestObjects.Controls.Common.Header;
using XedoFramework.Model.TestObjects.Pages;
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

        public static ExclusiveAccessPage ExclusiveAccessPage
        {
            get { return new ExclusiveAccessPage(GetTestSettings()); }
        }

        public static QuickTryOnPage QuickTryOnPage
        {
            get { return new QuickTryOnPage(GetTestSettings()); }
        }

        public static OutfitBuilderPage OutfitBuilderPage
        {
            get { return new OutfitBuilderPage(GetTestSettings()); }
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


        protected const string QuickTryOnContextName = "QuickTryOnContext";

        protected static QuickTryOnContext CurrentQuickTryOnContext
        {
            get { return (QuickTryOnContext)ScenarioContext.Current[QuickTryOnContextName]; }
            set { ScenarioContext.Current[QuickTryOnContextName] = value; }
        }


    }
}
