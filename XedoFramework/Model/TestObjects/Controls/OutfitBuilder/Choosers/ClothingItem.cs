using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers
{
    public abstract class ClothingItem : ControlBase
    {
        public IWebElement _container;

        protected ClothingItem(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }

        public IWebElement ItemDetails
        {
            get { return Driver.FindElement(_container, Locators.ItemDetails); }
        }

        public bool Selected
        {
            get { return _container.FindElements(Locators.SelectedWrapper).Any(); }
        }

        public void Select()
        {
            if (!Selected)
            {
                Utils.ScrollToElement(Driver, _container);
                _container.Click();
            }
        }

        public void Deselect()
        {
            if (Selected)
            {
                _container.Click();
            }
        }

        public string NameAsIs
        {
            get { return NameLabel.Text; }
        }

        public string Name
        {
            get { return NameLabel.Text.Replace("\n", " ").Replace("\r", " ").Replace("  ", " "); }
        }

        public string ID
        {
            get { return ItemDetails.GetAttribute("id"); }
        }

        public bool Available
        {
            get { return _container.FindElements(Locators.AvailableDate).Count == 0; }
        }

        public string AvailableFromDate
        {
            get
            {
                if (Available) return null;
                return Driver.FindElement(_container, Locators.AvailableDate).Text;
            }
        }

        public class Locators
        {
            public static By NameLabel = By.XPath(".//*[@class='item-text-link']");
            public static By Wrapper = By.XPath("//span[contains(@class, 'img-wrap')]");
            public static By SelectedWrapper = By.XPath("//span[@class='img-wrap selected']");
            public static By AvailableDate = By.XPath("//*[@class='item-unavailable-date-inner']");
            public static By ItemDetails { get; internal set; }
        }
    }
}
