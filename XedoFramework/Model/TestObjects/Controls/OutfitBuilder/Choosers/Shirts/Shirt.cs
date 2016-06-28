using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Shirts
{
    internal class Shirt : ClothingItem
    {
        public Shirt(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
            Locators.ItemDetails = By.XPath("//*[@data-level='shirt']");
        }
    }
}
