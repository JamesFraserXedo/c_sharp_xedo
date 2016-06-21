using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Model.TestObjects.Bases
{
    public abstract class TestObjectBase
    {
        public TestSettings TestSettings;

        protected TestObjectBase(TestSettings testSettings)
        {
            TestSettings = testSettings;
        }

        public IWebDriver Driver
        {
            get { return TestSettings.Driver; }
        }

        public Utils.SiteVersion SiteVersion
        {
            get { return TestSettings.SiteVersion; }
        }

        public string BaseUrl
        {
            get { return TestSettings.BaseUrl; }
        }
    }
}