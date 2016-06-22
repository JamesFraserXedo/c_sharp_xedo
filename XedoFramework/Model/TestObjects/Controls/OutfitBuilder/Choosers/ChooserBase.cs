using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers
{
    public abstract class ChooserBase : ControlBase
    {
        protected ChooserBase(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }
        
        public class Locators
        {
            public static By HeadingContainer = By.XPath("/header");
            public static By Container = By.Id("catalogue");
        }
    }
}