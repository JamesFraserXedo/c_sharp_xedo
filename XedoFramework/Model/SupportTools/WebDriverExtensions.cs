using System;
using OpenQA.Selenium;

namespace XedoFramework.SupportTools
{
    public static class WebDriverExtensions
    {

        public static IWebElement FindElement(this IWebDriver driver, By loc)
        {
            if(Utils.ElementExists(driver, loc))
            {
                return Utils.FindElement(driver, loc);
            }
            return null;
        }

        public static IWebElement FindElement(this IWebDriver driver, IWebElement parent, By loc)
        {
            return Utils.FindElement(driver, parent, loc);
        }

        public static bool ElementDisplayed(this IWebDriver driver, By loc)
        {
            return Utils.ElementDisplayed(driver, loc);
        }

    }
}
