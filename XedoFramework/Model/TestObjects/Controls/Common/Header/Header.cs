using OpenQA.Selenium;
using XedoFramework.SupportTools;
using XedoFramework.TestObjects.Bases;

namespace XedoFramework.TestObjects.Controls
{
    public class Header : ControlBase
    {
        public Header(TestSettings testSettings) : base(testSettings) {
            
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }
        
        public IWebElement OpenLoginPanelButton
        {
            get { return Driver.FindElement(Container, Locators.OpenLoginPanelButton); }
        }

        public static class Locators
        {
            public static readonly By Container = By.XPath("//div[contains(@class, 'header-container')]");
            public static readonly By OpenLoginPanelButton = By.XPath("//span[contains(text(), 'Sign In')]");
        }

            /*
             * Main logo
             * Collections
             * How it works
             * HomeIcon ?
             * Get Inspired
             * Create your look
             * Inspire me
             * 
             * Burger
             * 
             * Login/register text / icon
             */

        }
}
