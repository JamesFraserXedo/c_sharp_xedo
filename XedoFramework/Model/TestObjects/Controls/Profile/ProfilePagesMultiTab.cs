using OpenQA.Selenium;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.Profile
{
    public class ProfilePagesMultiTab : ControlBase
    {
        public ProfilePagesMultiTab(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement ManageProfileTabButton
        {
            get { return Driver.FindElement(Locators.ManageProfileTabButton); }
        }

        public IWebElement OrdersTabButton
        {
            get { return Driver.FindElement(Locators.OrdersTabButton); }
        }

        public IWebElement AddressBookTabButton
        {
            get { return Driver.FindElement(Locators.AddressBookTabButton); }
        }

        public IWebElement FavouritesTabButton
        {
            get { return Driver.FindElement(Locators.FavouritesTabButton); }
        }

        public class Locators
        {
            public static By ManageProfileTabButton = By.Id("ManageProfile");
            public static By OrdersTabButton = By.Id("Orders");
            public static By AddressBookTabButton = By.Id("AddressBook");
            public static By FavouritesTabButton = By.Id("Favourites");
        }
    }
}
