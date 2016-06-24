using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Neckwears
{
    public class NeckwearChooser : ChooserBase
    {
        public NeckwearChooser(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Neckwear(TestSettings, e).Select();
        }

        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Neckwear(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }

        public void ShowTies()
        {
            Driver.FindElement(Container, Locators.TieOptionsSelector).Click();
        }

        public void ShowBowTies()
        {
            Driver.FindElement(Container, Locators.BowTieOptionsSelector).Click();
        }

        public new class Locators : ChooserBase.Locators
        {
            public static By TieOptionsSelector = By.XPath("//*[contains(@class, 'neckwear-holder click-target')][1]");
            public static By BowTieOptionsSelector = By.XPath("//*[contains(@class, 'neckwear-holder click-target')][2]");
        }
    }
}
