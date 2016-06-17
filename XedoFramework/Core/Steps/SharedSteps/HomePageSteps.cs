using XedoFramework.Core.Steps.StepsSupport;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using XedoFramework.Model.Sites;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class HomePageSteps : StepBase
    {
        [Given(@"I am on the (.*) (.*) page")]
        public void GivenIAmOnTheSite(Site site, Page page)
        {
            Driver.Navigate().GoToUrl(UrlBuilder.GetUrl(site, page));
        }
        
        [Given(@"I have passed the (.*) exclusive access")]
        public void GivenIHavePassedTheSiteExclusiveAccess(Site site)
        {
            Driver.Navigate().GoToUrl(UrlBuilder.GetUrl(site, Page.Home));
            ExclusiveAccessPage.InputPassword("atlanta123");
            ExclusiveAccessPage.Submit();
        }

        [When(@"I click the login button in the header")]
        public void WhenIClickTheLoginButtonInTheHeader()
        {
            Header.OpenLoginPanelButton.Click();
        }
        
        [Then(@"the login panel should be open")]
        public void ThenTheLoginPanelShouldBeOpen()
        {
            Assert.IsTrue(LoginForm.Expanded);            
        }

        [Then(@"The main image content is visible")]
        public void ThenTheMainImageContentIsVisible()
        {
            Assert.IsTrue(HomePage.MainImageContent.Displayed);
        }

    }
}
