using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Pages;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters
{
    public class NeckwearFilter : ExpandableFilterBase
    {
        public NeckwearFilter(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings, builder)
        {
            FilterBase.Locators.Container = By.Id("filters-neckwear");
            SetActive();
        }
    }
}