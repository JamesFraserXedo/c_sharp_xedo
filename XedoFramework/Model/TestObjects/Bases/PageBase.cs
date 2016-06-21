using System;
using System.Diagnostics;
using System.Threading;
using XedoFramework.Model.TestObjects.Controls.Common.Footer;
using XedoFramework.Model.TestObjects.Controls.Common.Header;

namespace XedoFramework.Model.TestObjects.Bases
{
    public abstract class PageBase : TestObjectBase
    {
        public Header Header;
        public Footer Footer;

        protected int PageTimeoutSeconds = 15;

        protected PageBase(TestSettings testSettings) : base(testSettings)
        {
            Header = new Header(testSettings);
            Footer = new Footer(testSettings);
            WaitUntilLoaded();
        }

        public string Url
        {
            get { return Driver.Url; }
        }

        public string Title
        {
            get { return Driver.Title; }
        }

        public string Source
        {
            get { return Driver.PageSource; }
        }

        public void Back()
        {
            Driver.Navigate().Back();
        }

        public void Forward()
        {
            Driver.Navigate().Forward();
        }

        public void WaitUntilLoaded()
        {
            var s = new Stopwatch();
            s.Start();
            while (!IsLoaded() && s.Elapsed < TimeSpan.FromSeconds(PageTimeoutSeconds))
            {
                Thread.Sleep(1000);
            }
            s.Stop();
            if (!IsLoaded())
            {
                throw new TimeoutException(string.Format("The page did not load within {0} seconds", PageTimeoutSeconds));
            }
        }

        public abstract bool IsLoaded();

        public abstract void SetupState();
    }
}
