using System;
using XedoFramework.TestObjects.Bases;

namespace XedoFramework.TestObjects.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }
    }
}
