using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XedoFramework.Model.SupportTools;

namespace XedoFramework.Core.Steps.StepsSupport
{
    class ScreenshotCreator
    {
        public static void CreateErrorScreenshot(IWebDriver driver)
        {
            var filename = MakeErrorScreenshotFilename();
            try
            {
                Utils.TakeScreenshot(driver, filename);
                filename = AppDomain.CurrentDomain.BaseDirectory + "\\" + Utils.ErrorScreenshotDirName + filename;

                if (String.IsNullOrEmpty(filename))
                {
                    return;
                }

                Console.WriteLine("{0}Error screenshot created: {0}{0}{1}{0}", Environment.NewLine, filename);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("{0}Unfortunately we were unable to take a failure screenshot.  This is likely because the remote browser or node were disconnected.{0}", Environment.NewLine);
            }
        }

        private static string MakeErrorScreenshotFilename()
        {
            // Reducing name length to avoid path length problems
            return DateTime.Now.ToString("hh-mm-ss-ffff") + ".png";
        }
    }
}
