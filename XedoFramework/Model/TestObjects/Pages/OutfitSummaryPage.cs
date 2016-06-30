using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.OutfitSummary;

namespace XedoFramework.Model.TestObjects.Pages
{
    public class OutfitSummaryPage : PageBase
    {
        public OutfitSummaryPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement AddToOrderButton
        {
            get { return Driver.FindElement(Locators.AddToOrderButton); }
        }

        public IWebElement OrderFreeTryOnButton
        {
            get { return Driver.FindElement(Locators.OrderFreeTryOnButton); }
        }

        public IWebElement CustomiseTuxButton
        {
            get { return Driver.FindElement(Locators.CustomiseTuxButton); }
        }

        public IWebElement TotalLabel
        {
            get { return Driver.FindElement(Locators.TotalLabel); }
        }

        public OutfitSummaryObject TuxSummaryObject
        {
            get { return new OutfitSummaryObject(TestSettings, Driver.FindElement(Locators.TuxSummaryObject));}
        }

        public OutfitSummaryObject WaistcoatSummaryObject
        {
            get { return new OutfitSummaryObject(TestSettings, Driver.FindElement(Locators.WaistcoatSummaryObject)); }
        }

        public OutfitSummaryObject NeckwearSummaryObject
        {
            get { return new OutfitSummaryObject(TestSettings, Driver.FindElement(Locators.NeckwearSummaryObject)); }
        }

        public OutfitSummaryObject ShirtSummaryObject
        {
            get { return new OutfitSummaryObject(TestSettings, Driver.FindElement(Locators.ShirtSummaryObject)); }
        }

        public OutfitSummaryObject AccessoriesSummaryObject
        {
            get { return new OutfitSummaryObject(TestSettings, Driver.FindElement(Locators.AccessoriesSummaryObject)); }
        }

        public string TotalDue
        {
            get { return TotalLabel.Text; }
        }

        public override bool IsLoaded()
        {
            return !Driver.ElementDisplayed(Locators.IsLoadingSpinner);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By CustomiseTuxButton = By.XPath("//div[contains(@class, 'customize-look-holder')]/a");
            public static By TuxSummaryObject = By.XPath("//div[@data-at='click-jacket']");
            public static By WaistcoatSummaryObject = By.XPath("//div[@data-at='click-waistcoat-cummerbund']");
            public static By NeckwearSummaryObject = By.XPath("//div[@data-at='click-neckwear']");
            public static By ShirtSummaryObject = By.XPath("//div[@data-at='click-shirt']");
            public static By AccessoriesSummaryObject = By.XPath("//div[@data-at='click-accessories']");
            public static By SummaryDetailsPanel = By.XPath("//div[@class='outfit-selection-content']");
            public static By AddToOrderButton = By.Id("placeorder");
            public static By OrderFreeTryOnButton = By.Id("book-try-on");

            public static By SubtotalPriceLabel = By.XPath("//span[@class='sub-total-amount']");
            public static By SubtotalDiscountByLabel = By.XPath("//span[@class='sub-total-discount']");
            public static By TotalLabel = By.XPath("//span[@class='total-amount']");

            public static By IsLoadingSpinner = By.XPath("//*[@class='outfit-builder ob-loading']");
        }
    }
}
