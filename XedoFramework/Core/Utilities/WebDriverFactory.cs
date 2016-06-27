using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
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
        public static string SaucelabsJobId;
        public static Utils.BrowserType CurrentBrowser;
        private const string EnvNotSetMessage = "Please specify an execution environment in App.config.";
        //private static readonly Configuration.Configuration Config = new Configuration.Configuration();

        internal static TestExecutionEnvironment GetTestExecutionEnvironment()
        {
            if (TestsConfig.TestExecutionEnvironment == TestExecutionEnvironment.Local)
                return TestExecutionEnvironment.Local;
            
            if (TestsConfig.TestExecutionEnvironment == TestExecutionEnvironment.Saucelabs)
                return TestExecutionEnvironment.Saucelabs;

            if (TestsConfig.TestExecutionEnvironment == TestExecutionEnvironment.Grid)
                return TestExecutionEnvironment.Grid;
            
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

                case TestExecutionEnvironment.Saucelabs:
                    driver = GetDriverForSauceLabs(CurrentBrowser);
                    break;
                case TestExecutionEnvironment.Grid:
                    driver = GetDriverForGrid(CurrentBrowser);
                    break;
                default:
                    throw new ArgumentException("Test execution environment not recognised.");
            }

            
            if (GetTestExecutionEnvironment() != TestExecutionEnvironment.Saucelabs)
            {
                driver.Manage().Window.Maximize();
                driver.Manage().Cookies.DeleteAllCookies();
            }
            

            return driver;
        }

        private static IWebDriver GetDriverForLocalEnvironment(Utils.BrowserType browserToUse)
        {
            switch (browserToUse)
            {
                case Utils.BrowserType.FIREFOX:
                    var binary = new FirefoxBinary(TestsConfig.FirefoxPath);
                    var profile = new FirefoxProfile();
                    return new FirefoxDriver(binary, profile);

                case Utils.BrowserType.IE:
                    var options = new InternetExplorerOptions
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

        private static IWebDriver GetDriverForSauceLabs(Utils.BrowserType browserType, string browserVersion = "")
        {
            const string seleniumVersion = "";
            DesiredCapabilities capabilities;

            var saucelabsUsername = TestsConfig.SaucelabsUsername;
            var saucelabsAccessKey = TestsConfig.SaucelabsAccessKey;
            var sauceLabsHubUrl = TestsConfig.SaucelabsHubUrl;
            var nodeQueueingTimeout = TimeSpan.FromSeconds(600);
            const string osPlatform = "Windows 7";

            switch (browserType)
            {
                case Utils.BrowserType.FIREFOX:
                    capabilities = DesiredCapabilities.Firefox();
                    if (browserVersion != "")
                    {
                        capabilities.SetCapability(CapabilityType.Version, browserVersion);
                    }
                    capabilities.SetCapability("platform", osPlatform);
                    capabilities.SetCapability("screen-resolution", "1280x1024");
                    capabilities.SetCapability("selenium-version", seleniumVersion);
                    break;
                case Utils.BrowserType.IE:

                    //var options = new InternetExplorerOptions { EnableNativeEvents = true };

                    capabilities = DesiredCapabilities.InternetExplorer();
                    if (browserVersion != "")
                    {
                        capabilities.SetCapability(CapabilityType.Version, browserVersion);
                    }
                    capabilities.SetCapability("platform", osPlatform);
                    capabilities.SetCapability("screen-resolution", "1280x1024");
                    capabilities.SetCapability("maxDuration", "600");
                    capabilities.SetCapability("selenium-version", seleniumVersion);
                    capabilities.SetCapability("ie.ensureCleanSession", true);

                    if (browserVersion == "8")
                        capabilities.SetCapability("iedriverVersion", "2.45.0");

                    break;
                case Utils.BrowserType.CHROME:
                    capabilities = DesiredCapabilities.Chrome();
                    if (browserVersion != "")
                    {
                        capabilities.SetCapability(CapabilityType.Version, browserVersion);
                    }
                    capabilities.SetCapability("platform", osPlatform);
                    var screenResolution = "1280x1024";
                    // OSX only supports 1024x768
                    if (osPlatform.Contains("OS X"))
                    {
                        screenResolution = "1024x768";
                    }

                    capabilities.SetCapability("screen-resolution", screenResolution);
                    capabilities.SetCapability("selenium-version", seleniumVersion);
                    break;
                default:
                    throw new ArgumentException("Unrecognised browser choice '" + browserType +
                                                "' when initialising driver for Saucelabs.");
            }

            capabilities.SetCapability("command-timeout", 300);

            capabilities.SetCapability("idle-timeout", 180);
            capabilities.SetCapability("locationContextEnabled", false);
            capabilities.SetCapability("username", saucelabsUsername);
            capabilities.SetCapability("accessKey", saucelabsAccessKey);

            //capabilities = ConfigureSauceTunnel(capabilities);

            capabilities.SetCapability("name", ScenarioContext.Current.ScenarioInfo.Title);
            capabilities.SetCapability("tags", ScenarioContext.Current.ScenarioInfo.Tags);

            var driver = new SaucelabsDriver(new Uri(sauceLabsHubUrl), capabilities, nodeQueueingTimeout);
            SaucelabsJobId = driver.JobId.ToString();
            return driver;
        }

        private static IWebDriver GetDriverForGrid(Utils.BrowserType browserType)
        {
            DesiredCapabilities capabilities;

            switch (browserType)
            {
                case Utils.BrowserType.FIREFOX:
                    capabilities = DesiredCapabilities.Firefox();
                    break;
                case Utils.BrowserType.IE:
                    capabilities = DesiredCapabilities.InternetExplorer();
                    capabilities.SetCapability("ie.ensureCleanSession", "true");
                    break;
                case Utils.BrowserType.CHROME:
                    capabilities = DesiredCapabilities.Chrome();
                    break;
                case Utils.BrowserType.SAFARI:
                    capabilities = DesiredCapabilities.Safari();
                    break;
                default:
                    throw new ArgumentException("Unrecognised browser choice '" + browserType +
                                                "' when initialising driver for Grid.");
            }

            var platform = browserType.Equals(Utils.BrowserType.SAFARI) ? PlatformType.Mac : PlatformType.Vista;
            capabilities.SetCapability(CapabilityType.Platform, new Platform(platform));
            // So we know who's using it
            capabilities.SetCapability("environment",
                                        String.Format("{0} ({1})", TestsConfig.GridIdentifier, Environment.MachineName));

            IWebDriver driver = new RemoteWebDriver(
                new Uri(TestsConfig.GridHubUrl), capabilities, TimeSpan.FromSeconds(900));
            

            return driver;
        }

        private static Utils.BrowserType GetBrowserChoiceFromEnvironment()
        {
            //var browserValue = Environment.GetEnvironmentVariable(TestsConfig.BrowserVariableName);
            var browserValue = TestsConfig.BrowserVariableName;

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
            Local,
            Saucelabs,
            Grid
        }
    }
}
