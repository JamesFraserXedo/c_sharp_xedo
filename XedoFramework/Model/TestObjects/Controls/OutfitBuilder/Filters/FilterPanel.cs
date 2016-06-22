using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Pages;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters
{
    public class FilterPanel : ControlBase
    {
        private OutfitBuilderPage _builder;
        public FilterPanel(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings)
        {
            _builder = builder;
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public SuitFilter SuitsFilter
        {
            get { return new SuitFilter(TestSettings, _builder); }
        }
        
        public class Locators
        {
            public static By Container = By.Id("filters-view");
        }
    }
}
