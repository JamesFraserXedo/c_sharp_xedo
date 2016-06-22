﻿using XedoFramework.Core.Contexts;
using XedoFramework.Core.Utilities;
using TechTalk.SpecFlow;

namespace XedoFramework.Core.Steps.StepsSupport
{
    public class ScenarioHooks : StepBase
    {
        [BeforeScenario]
        private void BeforeScenario()
        {
            ScenarioContext.Current[QuickTryOnContextName] = new QuickTryOnContext();

            Driver = WebDriverFactory.Get();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestFinaliser.TearDown();
        }
    }
}
