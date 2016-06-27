using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XedoFramework.Model.SupportTools
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
            IWebElement element;
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                element = wait.Until(drv => drv.FindElement(by));
            }
            else
            {
                element = driver.FindElement(by);
            }
            ShowElementOnScreen(driver, element);
            return element;
        }

        public static void WaitForElementToAppear(IWebDriver driver, By by, int timeout = Timeouts.StandardTimeout)
        {
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                wait.Until(drv => drv.FindDisplayedElements(by).Any());
            }
            else
            {
                throw new ArgumentException("Timeout cannot be zero");
            }
        }

        public static void WaitForElementToDisappear(IWebDriver driver, By by, int timeout = Timeouts.StandardTimeout)
        {
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                wait.Until(drv => drv.FindDisplayedElements(by).Count == 0);
            }
            else
            {
                throw new ArgumentException("Timeout cannot be zero");
            }
        }

        public static IWebElement FindElement(IWebDriver driver, IWebElement parent, By by, int timeout = Timeouts.StandardTimeout)
        {
            IWebElement element;
            if (timeout > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                element = wait.Until(drv => parent.FindElement(by));
            }
            else
            {
                element = parent.FindElement(by);
            }
            ShowElementOnScreen(driver, element);
            return element;
        }

        public static ReadOnlyCollection<IWebElement> FindDisplayedElements(IWebDriver driver, By loc)
        {
            var foundElements = driver.FindElements(loc);
            var displayedElements = foundElements.Where(foundElement => foundElement.Displayed).ToList();
            return displayedElements.AsReadOnly();
        }

        public static ReadOnlyCollection<IWebElement> FindDisplayedElements(IWebDriver driver, IWebElement parent, By loc)
        {
            var foundElements = parent.FindElements(loc);
            var displayedElements = foundElements.Where(foundElement => foundElement.Displayed).ToList();
            return displayedElements.AsReadOnly();
        }

        public static bool ElementExists(IWebDriver driver, By loc)
        {
            return driver.FindElements(loc).Count > 0;
        }

        public static bool ElementDisplayed(IWebDriver driver, By loc)
        {
            return FindDisplayedElements(driver, loc).Any();
        }

        public static bool ElementDisplayed(IWebDriver driver, IWebElement parent, By loc)
        {
            return FindDisplayedElements(driver, parent, loc).Any();
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

        public static void ShowElementOnScreen(IWebDriver driver, IWebElement element)
        {
            //((IJavaScriptExecutor) driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);

            var js = driver as IJavaScriptExecutor;
            var script = "window.scrollTo(" + element.Location.X + "," + (element.Location.Y - 400) + ");";
            js.ExecuteScript(script);
        }

        public static string TakeScreenshot(IWebDriver driver, string strFilename)
        {
            if (!Directory.Exists(ErrorScreenshotDirName))
            {
                Directory.CreateDirectory(ErrorScreenshotDirName);
            }

            // TODO: Deal with .format expectedText
            //var filePath = ErrorScreenshotDirName + strFilename + "raw.png";
            string filePath = ErrorScreenshotDirName + strFilename;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            // Bug: This could fail due to System.IO.PathTooLongException. Need a more intelligent mechanism.
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filePath, ImageFormat.Png);
            return filePath;
        }

        public static void HighlightElement(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }

        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static string StripBreaks(string input)
        {
            return input.Replace("\n", " ").Replace("\r", " ").Replace("  ", " ");
        }
    }
}
