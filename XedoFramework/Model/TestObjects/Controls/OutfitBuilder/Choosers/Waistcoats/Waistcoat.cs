using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Waistcoats
{
    internal class Waistcoat : ClothingItem
    {
        public Waistcoat(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
            Locators.ItemDetails = By.XPath("//*[@data-level='waistcoat']");
        }
    }
}
