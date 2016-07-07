using NUnit.Framework;
using NUnit.Framework.Compatibility;
using TechTalk.SpecFlow;
using XedoFramework.Core.Contexts;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.Sites;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class CommonSteps : StepBase
    {
        public CommonSteps(Context context) : base(context)
        {
        }

        [When(@"I go to the (.*) (.*) page")]
        [Given(@"I am on the (.*) (.*) page")]
        public void GivenIAmOnTheSite(Site site, Page page)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Driver.Navigate().GoToUrl(UrlBuilder.GetUrl(site, page));
            CurrentContext.LoadTime.PageLoadTime = stopwatch.ElapsedMilliseconds;

            if (ExclusiveAccessPage.OnPage)
            {
                ExclusiveAccessPage.InputPassword("atlanta123");
                ExclusiveAccessPage.Submit();
            }

            switch (page)
            {
                case Page.Home:
                    HomePage.WaitUntilLoaded();
                    break;
                case Page.QuickTryOn:
                    QuickTryOnPage.WaitUntilLoaded();
                    break;
                case Page.OutfitBuilder:
                    OutfitBuilderPage.WaitUntilLoaded();
                    break;
                case Page.Collections:
                    CollectionsPage.WaitUntilLoaded();
                    break;
            }

            stopwatch.Stop();
            CurrentContext.LoadTime.PageContentLoadTime = stopwatch.ElapsedMilliseconds;

        }

        //TODO
        [Then(@"I am on the (.*) (.*) page")]
        public void ThenIAmOnTheXedoOutfitBuilderPage(Site site, Page page)
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
