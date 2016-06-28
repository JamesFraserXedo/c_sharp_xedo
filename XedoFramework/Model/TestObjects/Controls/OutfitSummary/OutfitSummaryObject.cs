using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitSummary
{
    public class OutfitSummaryObject : ControlBase
    {
        private IWebElement _container;
        public OutfitSummaryObject(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement Icon
        {
            get { return Driver.FindElement(_container, Locators.Icon); }
        }

        public IWebElement Header
        {
            get { return Driver.FindElement(_container, Locators.Header); }
        }

        public IWebElement Item
        {
            get { return Driver.FindElement(_container, Locators.Item); }
        }

        public IWebElement PriceLabel
        {
            get { return Driver.FindElement(_container, Locators.PriceLabel); }
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(_container, Locators.EditButton); }
        }

        public IWebElement ShowDetailsButton
        {
            get { return Driver.FindElement(_container, Locators.ShowDetailsButton); }
        }

        public void Select()
        {
            ShowDetailsButton.Click();
        }

        public class Locators
        {
            public static By Icon = By.XPath(".//div[@class='outfit-options-photo']/*");
            public static By Header = By.XPath(".//div[@class='details']/h2");
            public static By Item = By.XPath(".//div[@class='details']/p");
            public static By PriceLabel = By.XPath(".//span[@class='componentPriceValue']");
            public static By EditButton = By.XPath(".//a[@class='product-type-edit ga-event-click']");
            public static By ShowDetailsButton = By.XPath(".//div[@class='outfit-options-arrow']/div");
            
        }
    }
}
