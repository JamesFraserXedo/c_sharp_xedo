using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters.Colour;
using XedoFramework.Model.TestObjects.Pages;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters
{
    public abstract class ExpandableFilterBase : FilterBase
    {
        public ExpandableFilterBase(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings, builder)
        {
        }
        
        public ColourFilter ColourFilter
        {
            get { return new ColourFilter(TestSettings, Container); }
        }

        public void Expand()
        {
            if (!Expanded)
            {
                HeadingContainer.Click();
            }
        }

        public void Close()
        {
            if (Expanded)
            {
                HeadingContainer.Click();
            }
        }

        public new class Locators : FilterBase.Locators
        {
            public new static By BodyContainer = By.XPath("/nav");
            public static By ColourFilters = By.Id("filters-styles");
            public static By StyleFiltersPanel = By.Id("filters-pane-style");
            public static By StyleFilters = By.Id("filters-styles");
        }
    }
}