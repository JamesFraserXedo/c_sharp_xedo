using System.Collections.ObjectModel;
using OpenQA.Selenium;
using System.Linq;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers
{
    public abstract class ChooserBase : ControlBase
    {
        protected ChooserBase(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public abstract ReadOnlyCollection<ClothingItem> Items { get; }

        public abstract ClothingType ClothingType { get; }
        
        public ClothingItem SelectedItem
        {
            get
            {
                if (!Container.FindElements(ClothingItem.Locators.SelectedWrapper).Any())
                {
                    return null;
                }
                var items = Items;
                return items.FirstOrDefault(item => item.Selected);
            }
        }

        public abstract void SelectItemByName(string name);

        internal IWebElement FindItemByName(string name)
        {
            return Driver.FindElement(Container, Locators.ItemWithName(name));
        }

        public ReadOnlyCollection<ClothingItem> GetItemsWithNameContaining(string search)
        {
            search = search.ToLower();
            var items = Items;
            var matchingItems = items.Where(item => item.Name.ToLower().Contains(search)).ToList();
            return matchingItems.AsReadOnly();
        }
        
        public class Locators
        {
            public static By HeadingContainer = By.XPath("/header");
            public static By Container = By.Id("catalogue-view");
            public static By Items = By.XPath(".//*[contains(@class, 'item ')]");

            public static By ItemWithName(string name)
            {
                return By.XPath(string.Format("//*[contains(@class, 'item ')]/*[text()='{0}']/..", name));
            }

            //One-based index
            public static By ItemWithIndex(int index)
            {
                return By.XPath(string.Format("//*[contains(@class, 'item ')][{0}]", index));
            }
        }
    }
}