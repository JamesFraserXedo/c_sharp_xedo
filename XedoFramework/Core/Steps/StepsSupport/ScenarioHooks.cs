using XedoFramework.Core.Utilities;
using TechTalk.SpecFlow;
using System;

namespace XedoFramework.Core.Steps.StepsSupport
{
    public class ScenarioHooks : StepBase
    {
        [BeforeScenario]
        private void BeforeScenario()
        {
            Console.WriteLine("Getting Driver");
            Driver = WebDriverFactory.Get();            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestFinaliser.TearDown();
        }
    }
}
