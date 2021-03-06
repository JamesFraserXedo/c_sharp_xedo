﻿using System.Collections.ObjectModel;
using System.Linq;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Shirts
{
    public class ShirtChooser : ChooserBase
    {
        public ShirtChooser(TestSettings testSettings) : base(testSettings)
        {
        }

        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Shirt(TestSettings, e).Select();
        }

        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Shirt(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }

        public override ClothingType ClothingType
        {
            get { return ClothingType.Shirt; }
        }
    }
}
