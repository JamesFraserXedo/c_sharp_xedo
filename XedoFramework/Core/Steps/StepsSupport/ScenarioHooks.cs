using XedoFramework.Core.Contexts;
using XedoFramework.Core.Utilities;
using TechTalk.SpecFlow;

namespace XedoFramework.Core.Steps.StepsSupport
{
    public class ScenarioHooks : StepBase
    {
        public ScenarioHooks(Context context) : base(context)
        {
        }

        [BeforeScenario]
        private void BeforeScenario()
        {
            ScenarioContext.Current[ContextName] = new Context();
            /*
            ScenarioContext.Current[QuickTryOnContextName] = new QuickTryOnContext();
            ScenarioContext.Current[CommonContextName] = new CommonContext();
            ScenarioContext.Current[UserJourneyContextName] = new UserJourneyContext();
            ScenarioContext.Current[LoadTimeContextName] = new LoadTimeContext();
            */
            Driver = WebDriverFactory.Get();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestFinaliser.TearDown();
        }
    }
}
