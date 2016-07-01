using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.PartyBuilder
{
    public class NewPartyMemberPopup : ControlBase
    {
        public NewPartyMemberPopup(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public SelectElement RoleSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.RoleSelect)); }
        }

        public IWebElement FirstNameInputBox
        {
            get { return Driver.FindElement(Container, Locators.FirstNameInputBox); }
        }

        public IWebElement LastNameInputBox
        {
            get { return Driver.FindElement(Container, Locators.LastNameInputBox); }
        }

        public SelectElement OutfitSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.OutfitSelect)); }
        }

        public IWebElement SubmitButton
        {
            get { return Driver.FindElement(Container, Locators.SubmitButton); }
        }

        public void Submit()
        {
            SubmitButton.Click();
            Driver.WaitForElementToDisappear(Locators.Container);
        }

        public class Locators
        {
            public static By Container = By.XPath("//*[@class='constrained-overlay-container container add-wearer-popup']");
            public static By RoleSelect = By.Id("EventRoleId");
            public static By FirstNameInputBox = By.Id("Wearer_FirstName");
            public static By LastNameInputBox = By.Id("Wearer_LastName");
            public static By OutfitSelect = By.XPath("//*[@class='add-wearer-input party-member-outfit']");
            public static By SubmitButton = By.XPath("//*[@data-at='btn-submit-party-member']");
        }
    }
}
