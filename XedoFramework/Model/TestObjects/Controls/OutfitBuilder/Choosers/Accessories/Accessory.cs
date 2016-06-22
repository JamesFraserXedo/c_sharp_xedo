using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Accessories
{
    public class Accessory : ClothingItem
    {
        public Accessory(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
        
        public new class Locators : ClothingItem.Locators
        {
            public new static By ItemDetails = By.XPath("//*[@data-level='accessories']");
        }
    }
}
