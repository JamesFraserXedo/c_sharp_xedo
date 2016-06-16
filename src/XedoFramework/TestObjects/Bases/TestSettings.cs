using OpenQA.Selenium;
using static XedoFramework.SupportTools.Utils;

namespace XedoFramework.TestObjects.Bases
{
    public class TestSettings
    {
        public IWebDriver Driver;
        public SiteVersion SiteVersion;
        public string BaseUrl;

        public TestSettings(IWebDriver driver)
        {
            Driver = driver;
            /*
            SiteVersion = siteVersion;
            switch (SiteVersion)
            {
                case SiteVersion.ALFRED_ANGELO:
                    BaseUrl = @"https://suitup-uk-test-web-aagroom.azurewebsites.net/";
                    break;
                case SiteVersion.PROM_GUY:
                    BaseUrl = @"https://suit-up-uat-promguy-us.azurewebsites.net/";
                    break;
                case SiteVersion.T_M_LEWIN:
                    BaseUrl = @"https://suitup-uk-test-web-tmlewin.azurewebsites.net/";
                    break;
                case SiteVersion.XEDO:
                    BaseUrl = @"https://uat-xedo-usa.azurewebsites.net/";
                    break;
                case SiteVersion.YOUNGS:
                    BaseUrl = @"https://uat-youngs-uk.azurewebsites.net/";
                    break;
            }
            */
        }
    }
}
