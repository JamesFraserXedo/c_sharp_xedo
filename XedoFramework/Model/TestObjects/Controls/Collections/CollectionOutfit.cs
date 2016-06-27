using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.Collections
{
    public class CollectionOutfit : ControlBase
    {
        private IWebElement _container;

        public CollectionOutfit(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public string Price
        {
            get { return Driver.FindElement(_container, Locators.PriceLabel).Text.Replace("Tux Price: ", "").Trim(); }
        }

        public string Name
        {
            get { return Utils.StripBreaks(Driver.FindElement(_container, Locators.NameLabel).Text); }
        }

        public void Select()
        {
            _container.Click();
        }

        public class Locators
        {
            public static By PriceLabel = By.XPath(".//span[@class='inspire-item-detail']");
            public static By NameLabel = By.XPath(".//span[@class='inspire-item-detail']/p");
        }
    }
}
