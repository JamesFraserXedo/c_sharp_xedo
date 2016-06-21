using OpenQA.Selenium;

namespace XedoFramework.Model.SupportTools
{
    public static class WebDriverExtensions
    {

        public static IWebElement FindElement(this IWebDriver driver, By loc)
        {
            return Utils.ElementExists(driver, loc) ? Utils.FindElement(driver, loc) : null;
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
