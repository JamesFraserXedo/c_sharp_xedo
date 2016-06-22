using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace XedoFramework.Core.Utilities
{
    class SaucelabsDriver : RemoteWebDriver
        {
            public SaucelabsDriver(ICommandExecutor commandExecutor, ICapabilities desiredCapabilities)
                : base(commandExecutor, desiredCapabilities)
            {
            }

            public SaucelabsDriver(ICapabilities desiredCapabilities)
                : base(desiredCapabilities)
            {
            }

            public SaucelabsDriver(Uri remoteAddress, ICapabilities desiredCapabilities)
                : base(remoteAddress, desiredCapabilities)
            {
            }

            public SaucelabsDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeout)
                : base(remoteAddress, desiredCapabilities, commandTimeout)
            {
            }

            public SessionId JobId { get { return SessionId; } }
        
    }
}
