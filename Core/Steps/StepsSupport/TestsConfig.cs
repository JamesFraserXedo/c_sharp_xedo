using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities;

namespace Core.Steps.StepsSupport
{
    public class TestsConfig
    {
        private static readonly Configuration.Configuration Configuration = new Configuration.Configuration();
        public static readonly int NodeQueueingTimeout = Int32.Parse(ConfigurationManager.AppSettings["NodeQueueingTimeout"]);

        public static readonly string BrowserVariableName = ConfigurationManager.AppSettings["BrowserVariableName"];
        public static readonly string BrowserVersionVariableName = ConfigurationManager.AppSettings["BrowserVersionVariableName"];

        public static readonly string FirefoxPath = ConfigurationManager.AppSettings["FirefoxPath"];
        public static readonly string IeServerPath = ConfigurationManager.AppSettings["IeServerPath"];
        public static readonly string ChromeDriverPath = ConfigurationManager.AppSettings["ChromeDriverPath"];

        public static string GridIdentifier
        {
            get
            {
                return String.IsNullOrEmpty(ConfigurationManager.AppSettings["GridIdentifier"])
                    ? "Flights C# Core"
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
                        /*
                    case "grid":
                        return WebDriverFactory.TestExecutionEnvironment.Grid;
                    case "saucelabs":
                        return WebDriverFactory.TestExecutionEnvironment.SauceLabs;
                        */
                    default:
                        throw new ConfigurationErrorsException(String.Format("Could not recognise the test execution environment specified in app.config: '{0}'",
                        ConfigurationManager.AppSettings["TestExecutionEnvironment"]));
                }
            }
        }
    }
}
