using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace XedoFramework.SupportTools
{
    public static class Utils
    {
        public const string ErrorScreenshotDirName = @"Screenshots\";

        public enum SiteVersion
        {
            ALFRED_ANGELO,
            PROM_GUY,
            T_M_LEWIN,
            XEDO,
            YOUNGS
        }

        public enum BrowserType
        {
            FIREFOX,
            IE,
            CHROME,
            SAFARI,
            OPERA,
            ANDROID,
            IPAD,
            IPHONE
        }

        public static bool IsAlertPresent(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
            catch (UnhandledAlertException)
            {
                return true;
            }
        }

        public static IWebElement FindElement(IWebDriver driver, By by, int timeout = Timeouts.StandardTimeout)
        {
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static IWebElement FindElement(IWebDriver driver, IWebElement parent, By by, int timeout = Timeouts.StandardTimeout)
        {
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(drv => parent.FindElement(by));
            }
            return parent.FindElement(by);
        }

        public static bool ElementExists(IWebDriver driver, By loc)
        {
            return driver.FindElements(loc).Count > 0;
        }

        public static bool ElementDisplayed(IWebDriver driver, By loc)
        {
            var elements = driver.FindElements(loc);
            if (elements.Count == 0) { return false; }
            return elements[0].Displayed;
        }

        public static void SendKeysSlowly(IWebElement element, string text, int mSecDelay = 250)
        {
            for (int i = 0; i < text.Length; i++)
            {
                element.SendKeys(text.ToCharArray()[i].ToString());
                Thread.Sleep(mSecDelay);
            }
            Thread.Sleep(mSecDelay * 2);
        }

        private static void Log(string text)
        {
            Console.WriteLine("     {0}: {1}", DateTime.Now.ToString("hh:mm:ss.fff"), text);
        }

        public static class Timeouts
        {
            public const int StandardTimeout = 5;
        }

    }
}
