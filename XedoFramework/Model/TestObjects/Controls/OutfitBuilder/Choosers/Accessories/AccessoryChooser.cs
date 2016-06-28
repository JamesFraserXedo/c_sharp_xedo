using System.Collections.ObjectModel;
using System.Linq;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Accessories
{
    public class AccessoryChooser : ChooserBase
    {
        public AccessoryChooser(TestSettings testSettings) : base(testSettings)
        {
        }

        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Accessory(TestSettings, e).Select();
        }

        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Accessory(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }
    }
}
