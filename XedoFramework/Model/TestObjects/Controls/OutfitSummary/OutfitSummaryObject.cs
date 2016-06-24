using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.Collections;

namespace XedoFramework.Model.TestObjects.Controls.OutfitSummary
{
    class OutfitSummaryObject : ControlBase
    {
        private IWebElement _container;
        public OutfitSummaryObject(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public class Locators
        {
            public static By Icon = By.XPath(".//div[@class='outfit-options-photo']/*");
            public static By Header = By.XPath("//div[@class='details']/h2");
            public static By Item = By.XPath("//div[@class='details']/p");
            public static By Price = By.XPath("//span[@class='componentPriceValue']");
            public static By EditButton = By.XPath("//a[@class='product-type-edit ga-event-click']");
            public static By ShowDetails = By.XPath("//div[@class='outfit-options-arrow']/div");
            
        }
    }
}
