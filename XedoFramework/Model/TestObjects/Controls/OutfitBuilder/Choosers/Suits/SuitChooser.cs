using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Suits
{
    public class SuitChooser : ChooserBase
    {
        public SuitChooser(TestSettings testSettings) : base(testSettings)
        {
        }

        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Suit(TestSettings, e).Select();
        }  
        
        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Suit(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }
    }
}
