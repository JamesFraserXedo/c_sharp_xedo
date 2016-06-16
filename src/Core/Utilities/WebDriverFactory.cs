using Core.Steps.StepsSupport;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static XedoFramework.SupportTools.Utils;

namespace Core.Utilities
{
    public class WebDriverFactory
    {
        public static BrowserType CurrentBrowser;
        private const string EnvNotSetMessage = "Please specify an execution environment in App.config.";
        private static readonly Configuration.Configuration Config = new Configuration.Configuration();

        internal static TestExecutionEnvironment GetTestExecutionEnvironment()
        {
            if (TestsConfig.TestExecutionEnvironment == TestExecutionEnvironment.Local)
                return TestExecutionEnvironment.Local;

            /*
            if (TestsConfig.TestExecutionEnvironment == TestExecutionEnvironment.SauceLabs)
                return TestExecutionEnvironment.Saucelabs;

            if (TestsConfig.TestExecutionEnvironment == TestExecutionEnvironment.Grid)
                return TestExecutionEnvironment.Grid;
            */
            return TestExecutionEnvironment.Local;
        }

        public static IWebDriver Get()
        {
            IWebDriver driver;

            CurrentBrowser = GetBrowserChoiceFromEnvironment();

            switch (GetTestExecutionEnvironment())
            {
                case TestExecutionEnvironment.Local:
                    driver = GetDriverForLocalEnvironment(CurrentBrowser);
                    break;
                /*
            case TestExecutionEnvironment.SauceLabs:
                driver = GetDriverForSauceLabs(CurrentBrowserType, browserVersion);
                break;
            case TestExecutionEnvironment.Grid:
                driver = GetDriverForGrid(CurrentBrowserType);
                break;
                */
                default:
                    throw new ArgumentException("Test execution environment not recognised.");
            }

            /*
            if (GetTestExecutionEnvironment() != TestExecutionEnvironment.SauceLabs)
            {
                driver.Manage().Window.Maximize();
                driver.Manage().Cookies.DeleteAllCookies();
            }
            */

            return driver;
        }

        private static IWebDriver GetDriverForLocalEnvironment(BrowserType browserToUse)
        {
            switch (browserToUse)
            {
                case BrowserType.FIREFOX:
                    FirefoxBinary binary = new FirefoxBinary(TestsConfig.FirefoxPath);
                    FirefoxProfile profile = new FirefoxProfile();
                    return new FirefoxDriver(binary, profile);

                case BrowserType.IE:
                    InternetExplorerOptions options = new InternetExplorerOptions
                    {
                        InitialBrowserUrl = "about:blank",
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        IgnoreZoomLevel = true,
                        RequireWindowFocus = true
                    };

                    return new InternetExplorerDriver(TestsConfig.IeServerPath, options);

                case BrowserType.CHROME:
                    return new ChromeDriver(TestsConfig.ChromeDriverPath);
                default:
                    throw new ArgumentException("Unrecognised browser choice '" + browserToUse +
                                                "' when initialising driver for local environment.");
            }
        }

        private static BrowserType GetBrowserChoiceFromEnvironment()
        {
            var browserValue = Environment.GetEnvironmentVariable(TestsConfig.BrowserVariableName);

            if (browserValue == null)
            {
                return BrowserType.FIREFOX;
            }

            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browserValue, true);
            }
            catch (ArgumentException)
            {
                throw new Exception(
                    string.Format(
                        "'{0}' is not one of the supported browsers! Try one of the following values: {1}.",
                        browserValue,
                        String.Join(", ", Enum.GetNames(typeof(BrowserType)))
                        )
                    );
            }
        }

        public enum TestExecutionEnvironment
        {
            Local
            //SauceLabs,
            //Grid
        }
    }
}
