using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers.Neckwears
{
    public class Neckwear : ClothingItem
    {
        public Neckwear(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public void SelectTies()
        {

        }

        public new class Locators : ClothingItem.Locators
        {
            public new static By ItemDetails = By.XPath("//*[@data-level='neckwear']");
            public new static By NameLabel = By.XPath("//*[contains(@class, 'colour-name')]");
            public static By TieOptionsSelector = By.XPath("//*[@class='neckwear-holder click-target ']");
        }
    }
}
