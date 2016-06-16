using Core.Utilities;
using TechTalk.SpecFlow;

namespace Core.Steps.StepsSupport
{
    public class ScenarioHooks : StepBase
    {
        [BeforeScenario]
        private void BeforeScenario()
        {
            Driver = WebDriverFactory.Get();            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestFinaliser.TearDown();
        }
    }
}
