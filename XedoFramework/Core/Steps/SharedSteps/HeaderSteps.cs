﻿using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public class HeaderSteps : StepBase
    {
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
