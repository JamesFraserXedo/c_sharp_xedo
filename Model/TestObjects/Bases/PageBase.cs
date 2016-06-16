using XedoFramework.TestObjects.Controls;
using XedoFramework.TestObjects.Controls.Common;

namespace XedoFramework.TestObjects.Bases
{
    public abstract class PageBase : TestObjectBase
    {
        public Header Header;
        public Footer Footer;

        protected PageBase(TestSettings testSettings) : base(testSettings)
        {
            Header = new Header(testSettings);
            Footer = new Footer(testSettings);
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

        public abstract bool IsLoaded();

        public abstract void SetupState();
    }
}
