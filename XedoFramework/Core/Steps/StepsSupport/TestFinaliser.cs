namespace XedoFramework.Core.Steps.StepsSupport
{
    public class TestFinaliser : StepBase
    {
        public static void TearDown()
        {
            QuitDriver();
        }

        private static void QuitDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
            Driver = null;
        }
    }
}
