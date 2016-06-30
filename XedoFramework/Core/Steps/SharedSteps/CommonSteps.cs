using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.Sites;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class CommonSteps : StepBase
    {
        [Given(@"I am on the (.*) (.*) page")]
        public void GivenIAmOnTheSite(Site site, Page page)
        {
            //Driver.Navigate().GoToUrl(UrlBuilder.GetUrl(site, Page.Home));
            Driver.Navigate().GoToUrl(UrlBuilder.GetUrl(site, page));
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
        }

        //TODO
        [Then(@"I am on the (.*) (.*) page")]
        public void ThenIAmOnTheXedoOutfitBuilderPage(Site site, Page page)
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
