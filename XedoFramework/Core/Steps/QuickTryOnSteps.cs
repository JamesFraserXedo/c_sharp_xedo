using XedoFramework.Core.Steps.StepsSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public sealed class QuickTryOnSteps : StepBase
    {
        [When(@"I enter a preferred Try On date")]
        public void WhenIEnterAPreferredTryOnDate()
        {
            QuickTryOnPage.QuickTryOnForm.PreferredDateDatePicker.SelectFirstAvailableDate();
        }

        [Then(@"this should be confirmed on my Try On order")]
        public void ThenThisShouldBeConfirmedOnMyTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"that I have previously entered a Try On delivery date")]
        public void GivenThatIHavePreviouslyEnteredATryOnDeliveryDate()
        {
            QuickTryOnPage.QuickTryOnForm.PreferredDateDatePicker.SelectFirstAvailableDate();
        }
        
        [When(@"I then amend my Try On delivery date")]
        public void WhenIThenAmendMyTryOnDeliveryDate()
        {
            QuickTryOnPage.QuickTryOnForm.PreferredDateDatePicker.SelectAvailableDate(1);
        }

        [Then(@"the new date should be updated on my Try On order")]
        public void ThenTheNewDateShouldBeUpdatedOnMyTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter an address_1 (.*)")]
        public void GivenIEnterAnAddress1(string address)
        {
            QuickTryOnPage.QuickTryOnForm.AddressOneInputBox.SendKeys(address);
            CurrentQuickTryOnContext.EnteredAddress1 = address;
        }

        [Given(@"I enter a city (.*)")]
        public void GivenIEnterACity(string city)
        {
            QuickTryOnPage.QuickTryOnForm.CityInputBox.SendKeys(city);
            CurrentQuickTryOnContext.EnteredCity = city;
        }

        [Given(@"I select a state (.*)")]
        public void GivenISelectAState(string state)
        {
            QuickTryOnPage.QuickTryOnForm.SelectStateByName(state);
            CurrentQuickTryOnContext.EnteredState = QuickTryOnPage.QuickTryOnForm.StateSelect.SelectedOption.Text;
            CurrentQuickTryOnContext.EnteredStateCode =
                QuickTryOnPage.QuickTryOnForm.StateSelect.SelectedOption.GetAttribute("value");
        }

        [Given(@"I enter a zip code (.*)")]
        public void GivenIEnterAZipCode(string zip)
        {
            QuickTryOnPage.QuickTryOnForm.ZipInputBox.SendKeys(zip);
            CurrentQuickTryOnContext.EnteredZip = zip;
        }

        [When(@"I confirm the delivery address")]
        public void WhenIConfirmTheDeliveryAddress()
        {
            QuickTryOnPage.QuickTryOnForm.ConfirmDeliveryAddress();
        }

        [Then(@"The address should be checked by Fedex")]
        public void ThenTheAddressShouldBeCheckedByFedex()
        {
            Assert.IsTrue(QuickTryOnPage.QuickTryOnForm.SuggestedAddressLabel.Displayed);
        }

        [When(@"I select the entered delivery address")]
        public void WhenISelectTheEnteredDeliveryAddress()
        {
            QuickTryOnPage.QuickTryOnForm.ConfirmUserEnteredAddressButton.Click();
        }

        [Then(@"The address should be saved as entered")]
        public void ThenTheAddressShouldBeSavedAsEntered()
        {
            var savedAddress = QuickTryOnPage.QuickTryOnForm.ConfirmedAddress;
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredAddress1));
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredCity));
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredState) || savedAddress.Contains(CurrentQuickTryOnContext.EnteredStateCode));
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredZip));
        }

        [Then(@"I should be warned that the address_1 field is required")]
        public void ThenIShouldBeWarnedThatTheAddress_1FieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.QuickTryOnForm.AddressOneMissingLabel.Displayed);
        }

        [Then(@"I should be warned that the city field is required")]
        public void ThenIShouldBeWarnedThatTheCityFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.QuickTryOnForm.CityMissingLabel.Displayed);
        }

        [Then(@"I should be warned that the state field is required")]
        public void ThenIShouldBeWarnedThatTheStateFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.QuickTryOnForm.StateMissingLabel.Displayed);
        }

        [Then(@"I should be warned that the zip field is required")]
        public void ThenIShouldBeWarnedThatTheZipFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.QuickTryOnForm.ZipMissingLabel.Displayed);
        }


        [Then(@"The address should not be saved")]
        public void ThenTheAddressShouldNotBeSaved()
        {
            Assert.IsFalse(QuickTryOnPage.QuickTryOnForm.AddressConfirmed);
        }
                
        [Then(@"I should be warned that the zip code is invalid")]
        public void ThenIShouldBeWarnedThatTheZipCodeIsInvalid()
        {
            //Doesn't occur yet
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am logged on to the site")]
        public void GivenIAmLoggedOnToTheSite()
        {
            LoginForm.Login();
        }

        [Then(@"the address should be saved as entered into my address book")]
        public void ThenTheAddressShouldBeSavedAsEnteredIntoMyAddressBook()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"saved as the shipping address for the try on order")]
        public void ThenSavedAsTheShippingAddressForTheTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I choose to save the address as my default address")]
        public void GivenIChooseToSaveTheAddressAsMyDefaultAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the address should be saved as entered into my address book as the default address")]
        public void ThenTheAddressShouldBeSavedAsEnteredIntoMyAddressBookAsTheDefaultAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select the suggested delivery address from Fedex")]
        public void WhenISelectTheSuggestedDeliveryAddressFromFedex()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the address should be saved as suggested by Fedex")]
        public void ThenTheAddressShouldBeSavedAsSuggestedByFedex()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I havent confirmed my order yet")]
        [Given(@"I am not logged on to the site")]
        public void GivenIHaveNot()
        {
            //Do nothing
        }
        
        [Given(@"I do not enter an (.*)")]
        [Given(@"I do not enter a (.*)")]
        [Given(@"I do not select a (.*)")]
        public void GivenIDoNot(string p0)
        {
            //Do nothing
        }
    }
}
