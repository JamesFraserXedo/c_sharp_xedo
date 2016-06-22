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

        /*
        public void SetJobPassStatus(bool passed)
        {
            var url = string.Format("https://saucelabs.com/rest/v1/{0}/jobs/{1}", _username, _jobId);

            var data = "{\"passed\": " + passed +"}";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(_username, _accessKey);
            request.Method = "PUT";
            //request.ContentLength = data.Length;
            request.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            var dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
            var responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);

            reader.Close();
            dataStream.Close();
            response.Close();
        }
        */
    }
}
