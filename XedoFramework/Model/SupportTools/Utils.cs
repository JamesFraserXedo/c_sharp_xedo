﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        public static void ShowElementOnScreen(IWebDriver driver, IWebElement element)
        {
            //((IJavaScriptExecutor) driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);

            var js = driver as IJavaScriptExecutor;
            var script = "window.scrollTo(" + element.Location.X + "," + (element.Location.Y - 400) + ");";
            js.ExecuteScript(script);
        }
    }
}
