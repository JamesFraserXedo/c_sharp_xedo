using OpenQA.Selenium;
using static XedoFramework.SupportTools.Utils;

namespace XedoFramework.TestObjects.Bases
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

        public SiteVersion SiteVersion
        {
            get { return TestSettings.SiteVersion; }
        }

        public string BaseUrl
        {
            get { return TestSettings.BaseUrl; }
        }
    }
}