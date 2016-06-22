using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers;
using XedoFramework.Model.TestObjects.Pages;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters
{
    public abstract class FilterBase : ControlBase
    {
        private OutfitBuilderPage _builder;

        protected FilterBase(TestSettings testSettings, OutfitBuilderPage builder) : base(testSettings)
        {
            _builder = builder;
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement HeadingContainer
        {
            get { return Driver.FindElement(Container, Locators.HeadingContainer); }
        }

        public IWebElement BodyContainer
        {
            get { return Driver.FindElement(Container, Locators.BodyContainer); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Locators.BodyContainer); }
        }

        public bool Completed
        {
            get { return HeadingContainer.GetAttribute("class").EndsWith("complete"); }
        }

        public void SetActive()
        {
            if (!Expanded)
            {
                HeadingContainer.Click();
                _builder.WaitUntilLoaded();
            }
        }

        public class Locators
        {
            public static By HeadingContainer = By.XPath("/header");
            public static By BodyContainer = By.XPath("/nav");
            public static By Container { get; internal set; }
        }
    }
}