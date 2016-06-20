using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                //Driver.Quit();
            }
            Driver = null;
        }
    }
}
