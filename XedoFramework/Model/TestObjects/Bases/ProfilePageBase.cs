using XedoFramework.Model.TestObjects.Controls.Profile;

namespace XedoFramework.Model.TestObjects.Bases
{
    public abstract class ProfilePageBase : PageBase
    {
        protected ProfilePageBase(TestSettings testSettings) : base(testSettings)
        {
        }

        public ProfilePagesMultiTab ProfilePagesMultiTab
        {
            get { return new ProfilePagesMultiTab(TestSettings); }
        }
        
        public void GoToProfileTab()
        {
            ProfilePagesMultiTab.ManageProfileTabButton.Click();
        }
        
        public void GoToOrdersTab()
        {
            ProfilePagesMultiTab.OrdersTabButton.Click();
        }
        
        public void GoToAddressBookTab()
        {
            ProfilePagesMultiTab.AddressBookTabButton.Click();
        }

        public void GoToFavouritesTab()
        {
            ProfilePagesMultiTab.FavouritesTabButton.Click();
        }
    }
}
