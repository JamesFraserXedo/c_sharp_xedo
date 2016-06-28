using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Pages;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters
{
    public class ShirtFilter : FilterBase
    {
        public ShirtFilter(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings, builder)
        {
            Locators.Container = By.Id("filters-shirt");
            SetActive();
        }
    }
}