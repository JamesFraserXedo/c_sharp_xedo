using OpenQA.Selenium;
using System.Linq;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.OutfitBuilder.Dummy
{
    public class OutfitViewer : ControlBase
    {
        public OutfitViewer(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }
        
        public IWebElement BaseImage
        {
            get { return Driver.FindElement(Container, Locators.BaseImage); }
        }

        public IWebElement Jacket
        {
            get { return (WearingJacket ? Driver.FindElement(Container, Locators.Jacket) : null); }
        }

        public IWebElement Hankie
        {
            get { return (WearingHankie ? Driver.FindElement(Container, Locators.Hankie) : null); }
        }

        public IWebElement Neckwear
        {
            get { return (WearingNeckwear ? Driver.FindElement(Container, Locators.Neckwear) : null); }
        }

        public IWebElement Trousers
        {
            get { return (WearingTrousers ? Driver.FindElement(Container, Locators.Trousers) : null); }
        }

        public IWebElement Waistcoat
        {
            get { return (WearingWaistcoat ? Driver.FindElement(Container, Locators.Waistcoat) : null); }
        }

        public IWebElement Cummerbund
        {
            get { return (WearingWaistcoat ? Driver.FindElement(Container, Locators.Cummerbund) : null); }
        }

        public bool WearingJacket
        {
            get { return Container.FindElements(Locators.Jacket).Any(); }
        }

        public bool WearingHankie
        {
            get { return Container.FindElements(Locators.Hankie).Any(); }
        }

        public bool WearingNeckwear
        {
            get { return Container.FindElements(Locators.Neckwear).Any(); }
        }

        public bool WearingTrousers
        {
            get { return Container.FindElements(Locators.Trousers).Any(); }
        }

        public bool WearingWaistcoat
        {
            get { return Container.FindElements(Locators.Waistcoat).Any(); }
        }

        public bool WearingCummerbund
        {
            get { return Container.FindElements(Locators.Cummerbund).Any(); }
        }

        public class Locators
        {
            public static By Container = By.Id("main-outfit");
            public static By BaseImage = By.Id("initial-image");
            public static By Hankie = By.XPath("img-responsive ob-image protected-image hankie-holder hankie");
            public static By Jacket = By.XPath("//img[@class='img-responsive ob-image jacket']");
            public static By Neckwear = By.XPath("//img[@class='img-responsive ob-image neckwear']");
            public static By Trousers = By.XPath("//img[@class='img-responsive ob-image trousers']");
            public static By Waistcoat = By.XPath("//img[@class='img-responsive ob-image waistcoat']");
            public static By Cummerbund = By.XPath("//img[@class='img-responsive ob-image cummerbund']");
        }
    }
}
