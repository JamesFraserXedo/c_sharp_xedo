using OpenQA.Selenium;
using System;
using System.Threading;

namespace XedoFramework.SupportTools
{
    public static class WebElementExtensions
    {
        public static void SendKeysSlowly(this IWebElement element, string text, int mSecDelay = 250)
        {
            Utils.SendKeysSlowly(element, text, mSecDelay);
        }
    }
}
