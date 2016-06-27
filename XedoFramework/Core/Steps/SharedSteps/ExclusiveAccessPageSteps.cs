using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.Sites;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Core.Steps.SharedSteps
{
    [Binding]
    public sealed class ExclusiveAccessPageSteps : StepBase
    {
        [When(@"I enter ""(.*)"" into the exclusive access password box")]
        public void WhenIEnterIntoTheExclusiveAccessPasswordBox(string password)
        {
            ExclusiveAccessPage.InputPassword(password);
        }

        [When(@"I click the exclusive access submit button")]
        public void WhenIClickTheExclusiveAccessSubmitButton()
        {
            ExclusiveAccessPage.SubmitPasswordButton.Click();
        }
    }
}
