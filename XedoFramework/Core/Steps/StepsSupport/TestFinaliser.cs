using XedoFramework.Core.Utilities;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using TechTalk.SpecFlow;

namespace XedoFramework.Core.Steps.StepsSupport
{
    public class TestFinaliser : StepBase
    {
        public static void TearDown()
        {
            switch (WebDriverFactory.GetTestExecutionEnvironment())
            {
                case WebDriverFactory.TestExecutionEnvironment.Local:
                    LocalTearDown();
                    break;
                    
                case WebDriverFactory.TestExecutionEnvironment.Grid:
                    GridTearDown();
                    break;
                     
                case WebDriverFactory.TestExecutionEnvironment.Saucelabs:
                    SaucelabsTearDown();
                    break;
                default:
                    throw new ArgumentException("Could not tear down the session for this execution environment");
            }
        }

        private static void LocalTearDown()
        {
            QuitDriver();
        }

        private static void QuitDriver()
        {
            if (!DidTestPass())
            {
                TakeScreenshot();
            }
            if (Driver != null)
            {
                Driver.Quit();
            }
            Driver = null;
        }

        private static void SaucelabsTearDown()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("sauce:job-result=" + (DidTestPass() ? "passed" : "failed"));
            QuitDriver();
        }

        private static void GridTearDown()
        {
            QuitDriver();
        }

        private static bool DidTestPass()
        {
            return ScenarioContext.Current.TestError == null;
        }

        private static void TakeScreenshot()
        {
            ScreenshotCreator.CreateErrorScreenshot(Driver);
        }
    }
}
