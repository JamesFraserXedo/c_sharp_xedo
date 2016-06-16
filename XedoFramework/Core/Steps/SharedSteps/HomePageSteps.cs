using XedoFramework.Core.Steps.StepsSupport;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class HomePageSteps : StepBase
    {
        [Given(@"I am on the (.*) (.*)")]
        public void GivenIAmOnTheXedoHomepage(string site, string page)
        {
            if (site.ToLower() == "xedo")
            {
                if (page.ToLower() == "homepage")
                {
                    Console.WriteLine("Going to url with driver");
                    Driver.Navigate().GoToUrl(Urls.Xedo.HomePage);
                }
                else
                {
                    throw new ArgumentException("Must be a valid site page ('homepage')");
                }
            } else
            {
                throw new ArgumentException("Must be a valid site definition ('xedo')");
            }
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
    }
}
