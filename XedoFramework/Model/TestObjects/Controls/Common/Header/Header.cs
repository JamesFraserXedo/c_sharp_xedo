using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.Common.Header
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

        public class Locators
        {
            public static readonly By Container = By.XPath("//div[contains(@class, 'header-container')]");
            public static readonly By OpenLoginPanelButton = By.XPath("//*[contains(text(), 'Sign In')]");
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
