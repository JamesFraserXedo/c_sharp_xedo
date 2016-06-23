using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Utilities
{
    public class SaucelabsClient
    {
        private string _username;
        private string _accessKey;
        private string _jobId;

        public SaucelabsClient(string jobId)
        {
            _username = TestsConfig.SaucelabsUsername;
            _accessKey = TestsConfig.SaucelabsAccessKey;
            _jobId = jobId;
        }
    }
}
