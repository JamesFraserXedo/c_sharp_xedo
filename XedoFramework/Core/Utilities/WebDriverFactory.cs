using XedoFramework.Core.Steps.StepsSupport;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Core.Utilities
{
    public class WebDriverFactory
    {
        public static Utils.BrowserType CurrentBrowser;
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

        private static IWebDriver GetDriverForLocalEnvironment(Utils.BrowserType browserToUse)
        {
            switch (browserToUse)
            {
                case Utils.BrowserType.FIREFOX:
                    Console.WriteLine(TestsConfig.FirefoxPath);
                    FirefoxBinary binary = new FirefoxBinary(TestsConfig.FirefoxPath);
                    FirefoxProfile profile = new FirefoxProfile();
                    return new FirefoxDriver(binary, profile);

                case Utils.BrowserType.IE:
                    InternetExplorerOptions options = new InternetExplorerOptions
                    {
                        InitialBrowserUrl = "about:blank",
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        IgnoreZoomLevel = true,
                        RequireWindowFocus = true
                    };

                    return new InternetExplorerDriver(TestsConfig.IeServerPath, options);

                case Utils.BrowserType.CHROME:
                    return new ChromeDriver(TestsConfig.ChromeDriverPath);
                default:
                    throw new ArgumentException("Unrecognised browser choice '" + browserToUse +
                                                "' when initialising driver for local environment.");
            }
        }

        private static Utils.BrowserType GetBrowserChoiceFromEnvironment()
        {
            var browserValue = Environment.GetEnvironmentVariable(TestsConfig.BrowserVariableName);

            if (browserValue == null)
            {
                return Utils.BrowserType.FIREFOX;
            }

            try
            {
                return (Utils.BrowserType)Enum.Parse(typeof(Utils.BrowserType), browserValue, true);
            }
            catch (ArgumentException)
            {
                throw new Exception(
                    string.Format(
                        "'{0}' is not one of the supported browsers! Try one of the following values: {1}.",
                        browserValue,
                        String.Join(", ", Enum.GetNames(typeof(Utils.BrowserType)))
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
