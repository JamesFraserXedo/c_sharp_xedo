using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.QuickTryOn;

namespace XedoFramework.Model.TestObjects.Pages
{
    public class QuickTryOnPage : PageBase
    {
        public QuickTryOnPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public QuickTryOnForm QuickTryOnForm
        {
            get { return new QuickTryOnForm(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return QuickTryOnForm.Container.Displayed;
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(Urls.Xedo.QuickTryOnPage);
        }

        public class Locators
        {
            
        }
    }
}
