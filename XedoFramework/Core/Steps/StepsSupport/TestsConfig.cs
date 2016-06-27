using System;
using System.Configuration;
using XedoFramework.Core.Utilities;

namespace XedoFramework.Core.Steps.StepsSupport
{
    public class TestsConfig
    {
        //private static readonly Configuration.Configuration Configuration = new Configuration.Configuration();
        public static readonly int NodeQueueingTimeout = Int32.Parse(ConfigurationManager.AppSettings["NodeQueueingTimeout"]);

        public static readonly string BrowserVariableName = ConfigurationManager.AppSettings["BrowserVariableName"];
        public static readonly string BrowserVersionVariableName = ConfigurationManager.AppSettings["BrowserVersionVariableName"];

        public static readonly string FirefoxPath = ConfigurationManager.AppSettings["FirefoxPath"];
        public static readonly string IeServerPath = ConfigurationManager.AppSettings["IeServerPath"];
        public static readonly string ChromeDriverPath = ConfigurationManager.AppSettings["ChromeDriverPath"];

        public static readonly string SaucelabsUsername = ConfigurationManager.AppSettings["SaucelabsUsername"];
        public static readonly string SaucelabsAccessKey = ConfigurationManager.AppSettings["SaucelabsAccessKey"];
        public static readonly string SaucelabsHubUrl = ConfigurationManager.AppSettings["SaucelabsHubUrl"];

        public static readonly string GridHubUrl = ConfigurationManager.AppSettings["GridHubUrl"];


        public static string GridIdentifier
        {
            get
            {
                return String.IsNullOrEmpty(ConfigurationManager.AppSettings["GridIdentifier"])
                    ? "Xedo Testing"
                    : ConfigurationManager.AppSettings["GridIdentifier"];
            }
        }

        public static string BrowserType()
        {
            var browserType = Environment.GetEnvironmentVariable(BrowserVariableName);
            if (String.IsNullOrEmpty(browserType))
            {
                throw new Exception("Type of browser not set");
            }
            return browserType;
        }

        internal static WebDriverFactory.TestExecutionEnvironment TestExecutionEnvironment
        {
            get
            {
                switch (ConfigurationManager.AppSettings["TestExecutionEnvironment"].ToLower())
                {
                    case "local":
                        return WebDriverFactory.TestExecutionEnvironment.Local;

                    case "grid":
                        return WebDriverFactory.TestExecutionEnvironment.Grid;

                    case "saucelabs":
                        return WebDriverFactory.TestExecutionEnvironment.Saucelabs;

                    default:
                        throw new ConfigurationErrorsException(
                            String.Format(
                                "Could not recognise the test execution environment specified in app.config: '{0}'",
                                ConfigurationManager.AppSettings["TestExecutionEnvironment"]));
                }
            }
        }
    }
}
