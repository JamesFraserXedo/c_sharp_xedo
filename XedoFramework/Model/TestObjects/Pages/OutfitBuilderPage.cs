using System;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Choosers;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Dummy;
using XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Filters;

namespace XedoFramework.Model.TestObjects.Pages
{
    public class OutfitBuilderPage : PageBase
    {
        public OutfitBuilderPage(TestSettings testSettings) : base(testSettings)
        {
            WelcomePopup.Dismiss();
            WaitUntilLoaded();
        }

        public WelcomePopup WelcomePopup
        {
            get { return new WelcomePopup(TestSettings); }
        }

        public OutfitControls OutfitControls
        {
            get { return new OutfitControls(TestSettings, this); }
        }

        public FilterPanel FilterPanel
        {
            get { return new FilterPanel(TestSettings, this); }
        }

        public OutfitViewer OutfitViewer
        {
            get { return new OutfitViewer(TestSettings); }
        }

        public ChooserPanel ChooserPanel
        {
            get { return new ChooserPanel(TestSettings, this); }
        }

        public override bool IsLoaded()
        {
            return (!PageLoading && !ChoicePanelLoading && Driver.ElementDisplayed(ChooserPanel.Locators.Container));
        }

        public bool PageLoading
        {
            get { return Driver.ElementDisplayed(Locators.PageLoading); }
        }

        public bool ChoicePanelLoading
        {
            get
            {
                return Driver.ElementDisplayed(Locators.ChoicePanelLoading);
            }
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public ClothingType ActiveClothing
        {
            get { return ChooserPanel.CurrentChooser.ClothingType; }
        }

        public class Locators
        {
            public static By PageLoading = By.XPath("//*[@class='outfit-builder ob-loading']");
            public static By ChoicePanelLoading = By.XPath("//*[contains(@class, 'outfit-catalogue-col loading')]");
            
        }
    }
}
