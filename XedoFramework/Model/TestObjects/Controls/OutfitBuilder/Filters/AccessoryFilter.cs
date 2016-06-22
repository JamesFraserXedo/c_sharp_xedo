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
    public class AccessoryFilter : FilterBase
    {
        public AccessoryFilter(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings, builder)
        {
        }

        public new class Locators : FilterBase.Locators
        {
            public new static By Container = By.Id("filters-accessories");
        }
    }
}