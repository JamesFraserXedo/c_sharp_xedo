using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.Common.Header
{
    public class Header : ControlBase
    {
        public Header(TestSettings testSettings) : base(testSettings) {
            
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }
        
        public IWebElement OpenLoginPanelButton
        {
            get { return Driver.FindElement(Container, Locators.OpenLoginPanelButton); }
        }

        public IWebElement LoggedInUserNameLabel
        {
            get { return Driver.FindElement(Container, Locators.LoggedInUserNameLabel); }
        }

        public IWebElement OrdersButton
        {
            get { return Driver.FindElement(Container, Locators.OrdersButton); }
        }

        public IWebElement OrdersCountLabel
        {
            get { return Driver.FindElement(Container, Locators.OrdersCountLabel); }
        }

        public IWebElement FavouritesButton
        {
            get { return Driver.FindElement(Container, Locators.FavouritesButton); }
        }

        public IWebElement FavouritesCountLabel
        {
            get { return Driver.FindElement(Container, Locators.FavouritesCountLabel); }
        }

        public IWebElement LogoutButton
        {
            get { return Driver.FindElement(Container, Locators.LogoutButton); }
        }

        public bool LoggedIn
        {
            get { return Driver.ElementDisplayed(Locators.OpenLoginPanelButton); }
        }

        public string UserName
        {
            get { return LoggedInUserNameLabel.Text; }
        }

        public int NumberOfOrders
        {
            get { return Convert.ToInt32(OrdersCountLabel.Text); }
        }

        public int NumberOfFavourites
        {
            get { return Convert.ToInt32(FavouritesCountLabel.Text); }
        }

        public void Logout()
        {
            LogoutButton.Click();
        }

        public void GoToProfileSection()
        {
            LoggedInUserNameLabel.Click();
        }

        public class Locators
        {
            public static By Container = By.XPath("//div[contains(@class, 'header-container')]");
            public static By OpenLoginPanelButton = By.XPath("//*[contains(text(), 'Sign In')]");
            public static By LoggedInUserNameLabel = By.XPath("//span[@class='person-id']");
            public static By OrdersButton = By.Id("header-orders-button-with-count");
            public static By OrdersCountLabel = By.XPath("//*[@id='header-orders-button-with-count']/span");
            public static By FavouritesButton = By.Id("header-favourites-button-with-count");
            public static By FavouritesCountLabel = By.XPath("//*[@id='header-favourites-button-with-count']/span");
            public static By LogoutButton = By.Id("signout-link");
        }

            /*
             * Main logo
             * Collections
             * How it works
             * HomeIcon ?
             * Get Inspired
             * Create your look
             * Inspire me
             * 
             * Burger
             * 
             * Login/register text / icon
             */

        }
}
