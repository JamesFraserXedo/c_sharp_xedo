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
        }

        public WelcomePopup WelcomePopup
        {
            get { return new WelcomePopup(TestSettings); }
        }

        public OutfitControls OutfitControls
        {
            get { return new OutfitControls(TestSettings); }
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
            get { return new ChooserPanel(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return OutfitControls.Container.Displayed && !ChoicePanelLoading;
        }

        public bool ChoicePanelLoading
        {
            get { return Driver.ElementDisplayed(Locators.ChoicePanelLoading); }
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public class Locators
        {
            public static By ChoicePanelLoading = By.XPath("//*[contains(@class, 'outfit-catalogue-col loading')]");
        }
    }
}
