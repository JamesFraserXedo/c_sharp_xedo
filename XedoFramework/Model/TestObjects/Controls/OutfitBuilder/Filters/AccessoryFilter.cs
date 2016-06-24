using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Pages;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters
{
    public class AccessoryFilter : FilterBase
    {
        public AccessoryFilter(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings, builder)
        {
            Locators.Container = By.Id("filters-accessories");
            SetActive();
        }
    }
}