using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters.Colour
{
    public class ColourFilter : ControlBase
    {
        private IWebElement _parent;

        public ColourFilter(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _parent = container;
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(_parent, Locators.Container); }
        }

        public ReadOnlyCollection<IWebElement> ColourChoosers
        {
            get { return Container.FindElements(Locators.ColourChoosers); }
        }

        public IWebElement SelectedColourChooser
        {
            get {
                
                if (Container.FindElements(Locators.SelectedColourChooser).Any()) {
                    return Driver.FindElement(Container, Locators.SelectedColourChooser);
                }
                return null;
            }
        }

        public string SelectedColour
        {
            get { return SelectedColourChooser.GetAttribute("data-colour-desc"); }
        }

        public bool Active
        {
            get { return !(SelectedColourChooser == null); }
        }

        public ReadOnlyCollection<string> GetColourOptions()
        {
            var choosers = ColourChoosers;
            List<string> colours = new List<string>();
            foreach (var chooser in choosers)
            {
                colours.Add(chooser.GetAttribute("data-colour-desc"));
            }
            return colours.AsReadOnly();
        }

        public void Deselect()
        {
            if (Active)
            {
                SelectedColourChooser.Click();
            }
        }

        //Note: Case sensitive
        public void SelectColour(string colour)
        {
            if (Active)
            {
                if (SelectedColour == colour)
                {
                    return;
                }
            }

            var xpath = string.Format(".//li[@data-colour-desc='{0}']", colour);
            if (Container.FindElements(By.XPath(xpath)).Any())
            {
                Driver.FindElement(Container, By.XPath(xpath)).Click();
            }
            else
            {
                throw new ArgumentException("This colour was not available to select");
            }

        }

        public class Locators
        {
            public static By Container = By.Id("filters-colours");
            public static By SelectedColourChooser = By.XPath(".//li[contains(@class, 'selected')]");
            public static By ColourChoosers = By.XPath(".//li");
        }
    }
}
