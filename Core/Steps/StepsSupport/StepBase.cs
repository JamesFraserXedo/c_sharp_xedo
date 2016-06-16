using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XedoFramework.TestObjects.Bases;
using XedoFramework.TestObjects.Controls.Common;
using XedoFramework.TestObjects.Pages;

namespace Core.Steps.StepsSupport
{
    public class StepBase : TechTalk.SpecFlow.Steps
    {
        protected static IWebDriver Driver;
        protected static TestSettings GetTestSettings()
        {
            return new TestSettings(Driver);
        }

        public static HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }

        public static LoginForm LoginForm 
        {
            get { return new LoginForm(GetTestSettings()); }
        }
    }
}
