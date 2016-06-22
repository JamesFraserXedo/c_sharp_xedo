using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Suits
{
    public class Suit : ClothingItem
    {
        public Suit(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {           
        }
                
        public bool HasPocket
        {
            get { return (ItemDetails.GetAttribute("data-jacket-haspocket") == "True"); }
        }
        
        public new class Locators : ClothingItem.Locators
        {
            public new static By ItemDetails = By.XPath("//*[@data-level='jacket']");
        }
    }
}
