using System;
using XedoFramework.Core.Contexts;
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
            QuickTryOnPage.InfoForm.PreferredDateDatePicker.SelectFirstAvailableDate();
        }

        [Then(@"this should be confirmed on my Try On order")]
        public void ThenThisShouldBeConfirmedOnMyTryOnOrder()
        {
            ScenarioContext.Current.Pending();
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

        [Then(@"the new date should be updated on my Try On order")]
        public void ThenTheNewDateShouldBeUpdatedOnMyTryOnOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter an address_1 (.*)")]
        public void GivenIEnterAnAddress1(string address)
        {
            QuickTryOnPage.InfoForm.AddressOneInputBox.SendKeys(address);
            CurrentQuickTryOnContext.EnteredAddress1 = address;
        }

        [Given(@"I enter a city (.*)")]
        public void GivenIEnterACity(string city)
        {
            QuickTryOnPage.InfoForm.CityInputBox.SendKeys(city);
            CurrentQuickTryOnContext.EnteredCity = city;
        }

        [Given(@"I select a state (.*)")]
        public void GivenISelectAState(string state)
        {
            QuickTryOnPage.InfoForm.SelectStateByName(state);
            CurrentQuickTryOnContext.EnteredState = QuickTryOnPage.InfoForm.StateSelect.SelectedOption.Text;
            CurrentQuickTryOnContext.EnteredStateCode =
                QuickTryOnPage.InfoForm.StateSelect.SelectedOption.GetAttribute("value");
        }

        [Given(@"I enter a zip code (.*)")]
        public void GivenIEnterAZipCode(string zip)
        {
            QuickTryOnPage.InfoForm.ZipInputBox.SendKeys(zip);
            CurrentQuickTryOnContext.EnteredZip = zip;
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
        }

        [Then(@"The address should be saved as entered")]
        public void ThenTheAddressShouldBeSavedAsEntered()
        {
            var savedAddress = QuickTryOnPage.InfoForm.ConfirmedAddress;
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredAddress1));
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredCity));
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredState) || savedAddress.Contains(CurrentQuickTryOnContext.EnteredStateCode));
            Assert.IsTrue(savedAddress.Contains(CurrentQuickTryOnContext.EnteredZip));
        }

        [Then(@"I should be warned that the address_1 field is required")]
        public void ThenIShouldBeWarnedThatTheAddress_1FieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.AddressOneMissingLabel.Displayed);
        }

        [Then(@"I should be warned that the city field is required")]
        public void ThenIShouldBeWarnedThatTheCityFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.CityMissingLabel.Displayed);
        }

        [Then(@"I should be warned that the state field is required")]
        public void ThenIShouldBeWarnedThatTheStateFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.StateMissingLabel.Displayed);
        }

        [Then(@"I should be warned that the zip field is required")]
        public void ThenIShouldBeWarnedThatTheZipFieldIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.InfoForm.ZipMissingLabel.Displayed);
        }


        [Then(@"The address should not be saved")]
        public void ThenTheAddressShouldNotBeSaved()
        {
            Assert.IsFalse(QuickTryOnPage.InfoForm.AddressConfirmed);
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
        

        [Given(@"the Try-On has less then two Pocket Squares")]
        public void GivenTheTry_OnHasLessThenTwoPocketSquares()
        {
            QuickTryOnPage.ColourSelect.SecondSelectedColour.Remove();
        }

        [When(@"the Customer adds a Pocket Square")]
        public void WhenTheCustomerAddsAPocketSquare()
        {
            var element = QuickTryOnPage.ColourSelect.ChooseFirstAvailableColour();
            CurrentQuickTryOnContext.ThePocketSquareColour = element.GetAttribute("title");
        }

        [Then(@"the Pocket Square is added to the Try-On")]
        public void ThenThePocketSquareIsAddedToTheTry_On()
        {
            var squareColour = CurrentQuickTryOnContext.ThePocketSquareColour;
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
            var squareColour = CurrentQuickTryOnContext.ThePocketSquareColour;
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
            CurrentQuickTryOnContext.ThePocketSquareColour = QuickTryOnPage.ColourSelect.FirstSelectedColour.Name;
            QuickTryOnPage.ColourSelect.FirstSelectedColour.Remove();
        }

        [Then(@"the Pocket Square is removed from the Try-On")]
        public void ThenThePocketSquareIsRemovedFromTheTry_On()
        {
            var squareColour = CurrentQuickTryOnContext.ThePocketSquareColour;
            Assert.IsFalse(QuickTryOnPage.ColourSelect.SelectedColours.Contains(squareColour));
        }

        [When(@"the Customer removes a Pocket Square by re-selecting the Pocket Square colour")]
        public void WhenTheCustomerRemovesAPocketSquareByRe_SelectingThePocketSquareColour()
        {
            var element = QuickTryOnPage.ColourSelect.DeselectFirstSelectedColour();
            CurrentQuickTryOnContext.ThePocketSquareColour = element.GetAttribute("title");
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

        [Then(@"the Customer is informed that at least one Pocket Square is required")]
        public void ThenTheCustomerIsInformedThatAtLeastOnePocketSquareIsRequired()
        {
            Assert.IsTrue(QuickTryOnPage.ColourSelect.NoColoursSelectedMessage.Displayed);
        }

        [Given(@"the Try-On contains one Pocket Square")]
        public void GivenTheTry_OnContainsOnePocketSquare()
        {
            QuickTryOnPage.ColourSelect.SecondSelectedColour.Remove();
            if (!QuickTryOnPage.ColourSelect.FirstSelectedColour.Selected)
            {
                var element = QuickTryOnPage.ColourSelect.ChooseFirstAvailableColour();
                CurrentQuickTryOnContext.ThePocketSquareColour = element.GetAttribute("title");
            }
        }

        [When(@"the Customer attempts to add the same Pocket Square to the Try-On")]
        public void WhenTheCustomerAttemptsToAddTheSamePocketSquareToTheTry_On()
        {
            QuickTryOnPage.ColourSelect.SelectColour(CurrentQuickTryOnContext.ThePocketSquareColour);
        }

        [Then(@"the Pocket Square is not added to the Try-On twice")]
        public void ThenThePocketSquareIsNotAddedToTheTry_OnTwice()
        {
            Assert.IsTrue(QuickTryOnPage.ColourSelect.FirstSelectedColour.Name != QuickTryOnPage.ColourSelect.SecondSelectedColour.Name);
        }


    }
}
