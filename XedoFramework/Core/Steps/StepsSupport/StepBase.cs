using OpenQA.Selenium;
using TechTalk.SpecFlow;
using XedoFramework.Core.Contexts;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.Common;
using XedoFramework.Model.TestObjects.Controls.Common.Footer;
using XedoFramework.Model.TestObjects.Controls.Common.Header;
using XedoFramework.Model.TestObjects.Controls.PartyBuilder;
using XedoFramework.Model.TestObjects.Pages;
using XedoFramework.Model.TestObjects.Pages.PaymentProcess;
using XedoFramework.Model.TestObjects.Pages.Profile;
using XedoFramework.TestObjects.Pages;

namespace XedoFramework.Core.Steps.StepsSupport
{
    [Binding]
    public class StepBase : TechTalk.SpecFlow.Steps
    {
        protected static IWebDriver Driver;
        protected static TestSettings GetTestSettings()
        {
            return new TestSettings(Driver);
        }

        public Context Context;
        public StepBase(Context context)
        {
            Context = context;
        }

        public static HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }

        public static ExclusiveAccessPage ExclusiveAccessPage
        {
            get { return new ExclusiveAccessPage(GetTestSettings()); }
        }

        public static QuickTryOnPage QuickTryOnPage
        {
            get { return new QuickTryOnPage(GetTestSettings()); }
        }

        public static OutfitBuilderPage OutfitBuilderPage
        {
            get { return new OutfitBuilderPage(GetTestSettings()); }
        }

        public static CollectionsPage CollectionsPage
        {
            get { return new CollectionsPage(GetTestSettings()); }
        }
        public static OutfitSummaryPage OutfitSummaryPage
        {
            get { return new OutfitSummaryPage(GetTestSettings()); }
        }

        public static LoginForm LoginForm 
        {
            get { return new LoginForm(GetTestSettings()); }
        }

        public static NewMemberRegistrationPage NewMemberRegistrationPage
        {
            get { return new NewMemberRegistrationPage(GetTestSettings()); }
        }

        public static Header Header
        {
            get { return new Header(GetTestSettings()); }
        }

        public static Footer Footer
        {
            get { return new Footer(GetTestSettings()); }
        }

        public static ProfilePage ProfilePage
        {
            get { return new ProfilePage(GetTestSettings()); }
        }

        public static OrdersPage OrdersPage
        {
            get { return new OrdersPage(GetTestSettings()); }
        }

        public static AddressBookPage AddressBookPage
        {
            get { return new AddressBookPage(GetTestSettings()); }
        }

        public static FavouritesPage FavouritesPage
        {
            get { return new FavouritesPage(GetTestSettings()); }
        }

        public static SelectWeddingDatePage SelectWeddingDatePage
        {
            get { return new SelectWeddingDatePage(GetTestSettings()); }
        }

        public static BuildPartyPage BuildPartyPage
        {
            get { return new BuildPartyPage(GetTestSettings()); }
        }

        public static GroomGoesFreePopup GroomGoesFreePopup
        {
            get { return new GroomGoesFreePopup(GetTestSettings()); }
        }

        public static BillingAddressPage BillingAddressPage
        {
            get { return new BillingAddressPage(GetTestSettings()); }
        }

        public static PaymentOptionsPage PaymentOptionsPage
        {
            get { return new PaymentOptionsPage(GetTestSettings()); }
        }

        
        protected const string ContextName = "Context";

        protected static Context CurrentContext
        {
            get { return (Context)ScenarioContext.Current[ContextName]; }
            set { ScenarioContext.Current[ContextName] = value; }
        }

        /*
        protected const string QuickTryOnContextName = "QuickTryOnContext";
        protected const string CommonContextName = "CommonContext";
        protected const string UserJourneyContextName = "UserJourneyContext";
        protected const string LoadTimeContextName = "LoadTimeContext";
        
        
        protected static QuickTryOnContext CurrentContext.QuickTryOn
        {
            get { return (QuickTryOnContext)ScenarioContext.Current[QuickTryOnContextName]; }
            set { ScenarioContext.Current[QuickTryOnContextName] = value; }
        }

        protected static CommonContext CurrentCommonContext
        {
            get { return (CommonContext)ScenarioContext.Current[CommonContextName]; }
            set { ScenarioContext.Current[CommonContextName] = value; }
        }

        protected static UserJourneyContext CurrentUserJourneyContext
        {
            get { return (UserJourneyContext)ScenarioContext.Current[UserJourneyContextName]; }
            set { ScenarioContext.Current[UserJourneyContextName] = value; }
        }

        protected static LoadTimeContext CurrentLoadTimeContext
        {
            get { return (LoadTimeContext)ScenarioContext.Current[LoadTimeContextName]; }
            set { ScenarioContext.Current[LoadTimeContextName] = value; }
        }
         */
    }
}
