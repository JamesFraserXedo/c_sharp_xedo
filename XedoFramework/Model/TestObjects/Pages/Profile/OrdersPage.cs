using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Pages.Profile
{
    public class OrdersPage : ProfilePageBase
    {
        public OrdersPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.OrdersPanel);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By OrdersPanel = By.XPath("//div[@class='orders-section']");
        }
    }
}
