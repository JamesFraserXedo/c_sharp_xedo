using System;
using System.Linq;
using System.Threading;
using XedoFramework.Core.Contexts;
using XedoFramework.Core.Steps.StepsSupport;
using TechTalk.SpecFlow;
using NUnit.Framework;
using XedoFramework.Model.TestObjects.Pages.Profile;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public sealed class QuickTryOnSteps : StepBase
    {
        public QuickTryOnSteps(Context context) : base(context)
        {
        }

        [When(@"I enter a preferred Try On date")]
        public void WhenIEnterAPreferredTryOnDate()
        {
            QuickTryOnPage.InfoForm.PreferredDateDatePicker.SelectFirstAvailableDate();
        }

        [When(@"I enter a contact number (.*)")]
        public void WhenIEnterAContactNumber(string phone)
        {
            QuickTryOnPage.InfoForm.ContactNumberInputBox.SendKeys(phone);
        }


        [Given(@"that I have previously entered a Try On delivery date")]
        public void GivenThatIHavePreviouslyEnteredATryOnDeliveryDate()
        {
            QuickTryOnPage.InfoForm.PreferredDateDatePicker.SelectFirstAvailableDate();
        }
        
        [When(@"I then amend my Try On delivery date")]
        public void WhenIThenAmendMyTryOnDeliveryDate()
        {
            QuickTryOnPage.InfoForm.PreferredDateDatePicker.SelectAvailableDate(1);
        }

        [Given(@"I choose to enter the address")]
        public void GivenIChooseToEnterTheAddress()
        {
            QuickTryOnPage.InfoForm.SetToManualAddressInput();
        }

        [Given(@"I enter an address_1 (.*)")]
        public void GivenIEnterAnAddress1(string address)
        {
            QuickTryOnPage.InfoForm.AddressOneInputBox.SendKeys(address);
            CurrentContext.QuickTryOn.EnteredAddress1 = address;
        }

        [Given(@"I enter a city (.*)")]
        public void GivenIEnterACity(string city)
        {
            QuickTryOnPage.InfoForm.CityInputBox.SendKeys(city);
            CurrentContext.QuickTryOn.EnteredCity = city;
        }

        [Given(@"I select a state (.*)")]
        public void GivenISelectAState(string state)
        {
            QuickTryOnPage.InfoForm.SelectStateByName(state);
            CurrentContext.QuickTryOn.EnteredState = QuickTryOnPage.InfoForm.StateSelect.SelectedOption.Text;
            CurrentContext.QuickTryOn.EnteredStateCode =
                QuickTryOnPage.InfoForm.StateSelect.SelectedOption.GetAttribute("value");
        }

        [Given(@"I enter a zip code (.*)")]
        public void GivenIEnterAZipCode(string zip)
        {
            QuickTryOnPage.InfoForm.ZipInputBox.SendKeys(zip);
            CurrentContext.QuickTryOn.EnteredZip = zip;
        }

        [When(@"I confirm the delivery address")]
        public void WhenIConfirmTheDeliveryAddress()
        {
            QuickTryOnPage.InfoForm.ConfirmDeliveryAddress();
        }

        [Then(@"The address should be checked by Fedex")]
        public void ThenTheAddressShouldBeCheckedByFedex()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.SuggestedAddressLabel.Displayed);
        }

        [When(@"I select the entered delivery address")]
        public void WhenISelectTheEnteredDeliveryAddress()
        {
            QuickTryOnPage.InfoForm.ConfirmUserEnteredAddressButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"The address should be saved as entered")]
        public void ThenTheAddressShouldBeSavedAsEntered()
        {
            var savedAddress = QuickTryOnPage.InfoForm.ConfirmedAddress;
            Assert.IsTrue(savedAddress.Contains(CurrentContext.QuickTryOn.EnteredAddress1));
            Assert.IsTrue(savedAddress.Contains(CurrentContext.QuickTryOn.EnteredCity));
            Assert.IsTrue(savedAddress.Contains(CurrentContext.QuickTryOn.EnteredState) || savedAddress.Contains(CurrentContext.QuickTryOn.EnteredStateCode));
            Assert.IsTrue(savedAddress.Contains(CurrentContext.QuickTryOn.EnteredZip));
        }

        [Then(@"I should be warned that the first_name field is required")]
        public void ThenIShouldBeWarnedThatTheFirstNameFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please enter your First Name")));
        }

        [Then(@"I should be warned that the last_name field is required")]
        public void ThenIShouldBeWarnedThatTheLastNameFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please enter your Last Name")));
        }

        [Then(@"I should be warned that the address_1 field is required")]
        public void ThenIShouldBeWarnedThatTheAddress_1FieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please enter the first line of your address")));
        }

        [Then(@"I should be warned that the city field is required")]
        public void ThenIShouldBeWarnedThatTheCityFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please enter your City")));
        }

        [Then(@"I should be warned that the state field is required")]
        public void ThenIShouldBeWarnedThatTheStateFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please select your State")));
        }

        [Then(@"I should be warned that the zip field is required")]
        public void ThenIShouldBeWarnedThatTheZipFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please enter your Zip code")));
        }


        [Then(@"The address should not be saved")]
        public void ThenTheAddressShouldNotBeSaved()
        {
            Assert.IsFalse(QuickTryOnPage.InfoForm.AddressConfirmed);
        }
                
        [Then(@"I should be warned that the zip code is invalid")]
        public void ThenIShouldBeWarnedThatTheZipCodeIsInvalid()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.InvalidZipErrorLabel.Displayed);
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
        

        [Given(@"the Try-On has less then two Pocket Squares")]
        public void GivenTheTry_OnHasLessThenTwoPocketSquares()
        {
            QuickTryOnPage.ColourSelect.SecondSelectedColour.Remove();
        }

        [When(@"the Customer adds a Pocket Square")]
        public void WhenTheCustomerAddsAPocketSquare()
        {
            var element = QuickTryOnPage.ColourSelect.ChooseFirstAvailableColour();
            CurrentContext.QuickTryOn.ThePocketSquareColour = element.GetAttribute("title");
        }

        [Then(@"the Pocket Square is added to the Try-On")]
        public void ThenThePocketSquareIsAddedToTheTry_On()
        {
            var squareColour = CurrentContext.QuickTryOn.ThePocketSquareColour;
            Assert.IsTrue(QuickTryOnPage.ColourSelect.SelectedColours.Contains(squareColour));
        }

        [Given(@"the Try-On has the maximum number of Pocket Squares")]
        public void GivenTheTry_OnHasTheMaximumNumberOfPocketSquares()
        {
            while (!QuickTryOnPage.ColourSelect.SecondSelectedColour.Selected)
            {
                QuickTryOnPage.ColourSelect.ChooseFirstAvailableColour();
            }
        }

        [Then(@"the Customer is informed of the maximum number of Pocket Squares")]
        public void ThenTheCustomerIsInformedOfTheMaximumNumberOfPocketSquares()
        {
            Assert.IsTrue(QuickTryOnPage.ColourSelect.ColourLimitReachedMessage.Displayed);
        }

        [Then(@"the new Pocket Square is not added to the Try-On")]
        public void ThenTheNewPocketSquareIsNotAddedToTheTry_On()
        {
            var squareColour = CurrentContext.QuickTryOn.ThePocketSquareColour;
            Assert.IsFalse(QuickTryOnPage.ColourSelect.SelectedColours.Contains(squareColour));
        }

        [Given(@"the Try-On has at least one Pocket Square")]
        public void GivenTheTry_OnHasAtLeastOnePocketSquare()
        {
            if (!QuickTryOnPage.ColourSelect.FirstSelectedColour.Selected)
            {
                QuickTryOnPage.ColourSelect.ChooseFirstAvailableColour();
            }
        }

        [When(@"the Customer removes a Pocket Square")]
        public void WhenTheCustomerRemovesAPocketSquare()
        {
            CurrentContext.QuickTryOn.ThePocketSquareColour = QuickTryOnPage.ColourSelect.FirstSelectedColour.Name;
            QuickTryOnPage.ColourSelect.FirstSelectedColour.Remove();
        }

        [Then(@"the Pocket Square is removed from the Try-On")]
        public void ThenThePocketSquareIsRemovedFromTheTry_On()
        {
            var squareColour = CurrentContext.QuickTryOn.ThePocketSquareColour;
            Assert.IsFalse(QuickTryOnPage.ColourSelect.SelectedColours.Contains(squareColour));
        }

        [When(@"the Customer removes a Pocket Square by re-selecting the Pocket Square colour")]
        public void WhenTheCustomerRemovesAPocketSquareByRe_SelectingThePocketSquareColour()
        {
            var element = QuickTryOnPage.ColourSelect.DeselectFirstSelectedColour();
            CurrentContext.QuickTryOn.ThePocketSquareColour = element.GetAttribute("title");
        }

        [Given(@"the Try-On contains zero Pocket Squares")]
        public void GivenTheTry_OnContainsZeroPocketSquares()
        {
            QuickTryOnPage.ColourSelect.SecondSelectedColour.Remove();
            QuickTryOnPage.ColourSelect.FirstSelectedColour.Remove();
        }

        [When(@"the Customer places the Try-On Order")]
        public void WhenTheCustomerPlacesTheTry_OnOrder()
        {
            QuickTryOnPage.PlaceOrder();
        }

        [When(@"I accept the terms and conditions")]
        public void WhenIAcceptTheTermsAndConditions()
        {
            QuickTryOnPage.AgreeToTermsAndConditions();
        }


        [Then(@"the Customer is informed that at least one Pocket Square is required")]
        public void ThenTheCustomerIsInformedThatAtLeastOnePocketSquareIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ErrorMessages.Any(l => l.Contains("Please select at least one colour")));
        }

        [Given(@"the Try-On contains one Pocket Square")]
        public void GivenTheTry_OnContainsOnePocketSquare()
        {
            QuickTryOnPage.ColourSelect.SecondSelectedColour.Remove();
            if (!QuickTryOnPage.ColourSelect.FirstSelectedColour.Selected)
            {
                var element = QuickTryOnPage.ColourSelect.ChooseFirstAvailableColour();
                CurrentContext.QuickTryOn.ThePocketSquareColour = element.GetAttribute("title");
            }
        }

        [When(@"the Customer attempts to add the same Pocket Square to the Try-On")]
        public void WhenTheCustomerAttemptsToAddTheSamePocketSquareToTheTry_On()
        {
            QuickTryOnPage.ColourSelect.SelectColour(CurrentContext.QuickTryOn.ThePocketSquareColour);
        }

        [Then(@"the Pocket Square is not added to the Try-On twice")]
        public void ThenThePocketSquareIsNotAddedToTheTry_OnTwice()
        {
            Assert.IsTrue(QuickTryOnPage.ColourSelect.FirstSelectedColour.Name != QuickTryOnPage.ColourSelect.SecondSelectedColour.Name);
        }

        [When(@"I select the suggested delivery address from Fedex")]
        public void WhenISelectTheSuggestedDeliveryAddressFromFedex()
        {
            CurrentContext.QuickTryOn.FedexSuggestedAddress = QuickTryOnPage.InfoForm.SuggestedAddressLabel.Text;
            QuickTryOnPage.InfoForm.ConfirmSuggestedAddressButton.Click();
        }

        [Then(@"the address should be saved as suggested by Fedex")]
        public void ThenTheAddressShouldBeSavedAsSuggestedByFedex()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.ConfirmedAddress == CurrentContext.QuickTryOn.FedexSuggestedAddress);
        }

        [Given(@"I choose to save the address as my default address")]
        public void GivenIChooseToSaveTheAddressAsMyDefaultAddress()
        {
            QuickTryOnPage.InfoForm.SaveAsDefaultAddress();
        }

        [Then(@"this should be confirmed on my Try On order")]
        public void ThenThisShouldBeConfirmedOnMyTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the new date should be updated on my Try On order")]
        public void ThenTheNewDateShouldBeUpdatedOnMyTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the address should be saved as entered into my address book")]
        public void ThenTheAddressShouldBeSavedAsEnteredIntoMyAddressBook()
        {
            Header.GoToProfileSection();
            ProfilePage.GoToAddressBookTab();
            var matched = false;
            foreach (var address in AddressBookPage.Addresses)
            {
                if (address.Contains(CurrentContext.QuickTryOn.EnteredAddress1) &&
                    address.Contains(CurrentContext.QuickTryOn.EnteredCity) &&
                    (address.Contains(CurrentContext.QuickTryOn.EnteredState) || address.Contains(CurrentContext.QuickTryOn.EnteredStateCode)) &&
                    address.Contains(CurrentContext.QuickTryOn.EnteredZip))
                {
                    matched = true;
                }
            }
            Assert.IsTrue(matched);
        }

        [Then(@"saved as the shipping address for the try on order")]
        public void ThenSavedAsTheShippingAddressForTheTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the address should be saved as entered into my address book as the default address")]
        public void ThenTheAddressShouldBeSavedAsEnteredIntoMyAddressBookAsTheDefaultAddress()
        {
            Header.GoToProfileSection();
            ProfilePage.GoToAddressBookTab();
            var selectedAddress = AddressBookPage.SelectedAddress;
            Assert.IsTrue(selectedAddress.Contains(CurrentContext.QuickTryOn.EnteredAddress1));
            Assert.IsTrue(selectedAddress.Contains(CurrentContext.QuickTryOn.EnteredCity));
            Assert.IsTrue(selectedAddress.Contains(CurrentContext.QuickTryOn.EnteredState) || selectedAddress.Contains(CurrentContext.QuickTryOn.EnteredStateCode));
            Assert.IsTrue(selectedAddress.Contains(CurrentContext.QuickTryOn.EnteredZip));
        }
    }
}
