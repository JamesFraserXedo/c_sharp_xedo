using NUnit.Framework.Compatibility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;

namespace XedoFramework.Model.TestObjects.Controls.QuickTryOn
{
    public class InfoForm : ControlBase
    {
        public InfoForm(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public SelectElement HeightSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.HeightSelect)); }
        }

        public SelectElement WeightSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.WeightSelect)); }
        }

        public SelectElement CoatSizeSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.CoatSizeSelect)); }
        }

        public IWebElement FirstNameInputBox
        {
            get { return Driver.FindElement(Container, Locators.FirstNameInputBox); }
        }

        public IWebElement LastNameInputBox
        {
            get { return Driver.FindElement(Container, Locators.LastNameInputBox); }
        }

        public IWebElement AddressOneInputBox
        {
            get { return Driver.FindElement(Container, Locators.AddressOneInputBox); }
        }

        public IWebElement AddressTwoInputBox
        {
            get { return Driver.FindElement(Container, Locators.AddressTwoInputBox); }
        }

        public IWebElement CityInputBox
        {
            get { return Driver.FindElement(Container, Locators.CityInputBox); }
        }

        public SelectElement StateSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.StateSelect)); }
        }

        public IWebElement ZipInputBox
        {
            get { return Driver.FindElement(Container, Locators.ZipInputBox); }
        }

        public IWebElement ConfirmDeliveryAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmDeliveryAddressButton); }
        }

        public IWebElement SaveAsDefaultAddressCheckbox
        {
            get { return Driver.FindElement(Container, Locators.SaveAsDefaultAddressCheckbox); }
        }

        public IWebElement ContactNumberInputBox
        {
            get { return Driver.FindElement(Container, Locators.ContactNumberInputBox); }
        }

        public IWebElement WeddingDateInputBox
        {
            get { return Driver.FindElement(Container, Locators.WeddingDateInputBox); }
        }

        public IWebElement PreferredTryOnDateInputBox
        {
            get { return Driver.FindElement(Container, Locators.PreferredTryOnDateInputBox); }
        }

        public IWebElement CollectionDateLabel
        {
            get { return Driver.FindElement(Container, Locators.CollectionDateLabel); }
        }

        public IWebElement SuggestedAddressLabel
        {
            get { return Driver.FindElement(Container, Locators.SuggestedAddressLabel); }
        }

        public IWebElement ConfirmUserEnteredAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmUserEnteredAddressButton); }
        }

        public IWebElement ConfirmSuggestedAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmSuggestedAddressButton); }
        }

        public DatePicker WeddingDateDatePicker
        {
            get
            {
                WeddingDateInputBox.Click();
                Thread.Sleep(250);
                return new DatePicker(TestSettings, Driver.FindElement(Locators.WeddingDateDatePickerContainer));
            }
        }

        public DatePicker PreferredDateDatePicker
        {
            get
            {
                PreferredTryOnDateInputBox.Click();
                Thread.Sleep(250);
                return new DatePicker(TestSettings, Driver.FindElement(Locators.PreferredDateDatePickerContainer));
            }
        }

        public IWebElement AddressOneMissingLabel
        {
            get { return Driver.FindElement(Container, Locators.AddressOneMissingLabel); }
        }
        
        public IWebElement CityMissingLabel
        {
            get { return Driver.FindElement(Container, Locators.CityMissingLabel); }
        }

        public IWebElement StateMissingLabel
        {
            get { return Driver.FindElement(Container, Locators.StateMissingLabel); }
        }

        public IWebElement ZipMissingLabel
        {
            get { return Driver.FindElement(Container, Locators.ZipMissingLabel); }
        }

        public void SetToManualAddressInput()
        {
            if (Driver.ElementDisplayed(Container, Locators.InputNewAddressButton))
            {
                Driver.FindElement(Container, Locators.InputNewAddressButton).Click();
            }
        }

        public string CollectionDate
        {
            get
            {
                var date = "";
                var s = new Stopwatch();
                s.Start();
                while (date == "" && s.Elapsed < TimeSpan.FromSeconds(10))
                {
                    date = CollectionDateLabel.Text;
                }
                s.Stop();
                return date;
            }
        }

        public void SelectHeight(int feet, int inches)
        {
            HeightSelect.SelectByValue(string.Format("{0}'{1}\"", feet, inches));
        }

        public void SelectWeight(int pounds)
        {
            WeightSelect.SelectByValue(pounds.ToString());
        }

        public void SelectCoatSize(int inches, string size)
        {
            CoatSizeSelect.SelectByText(string.Format("{0}\" {1}", inches, size.ToUpper()));
        }

        public void SelectStateByName(string name)
        {
            StateSelect.SelectByText(name);
        }

        public void SelectStateByPostalCode(string postalCode)
        {
            CoatSizeSelect.SelectByValue(postalCode);
        }

        public void ConfirmDeliveryAddress()
        {
            ConfirmDeliveryAddressButton.Click();
            Driver.WaitForElementToDisappear(Locators.ConfirmDeliveryAddressButtonSpinner);
        }

        public void SaveAsDefaultAddress()
        {
            if (!SaveAsDefaultAddressCheckbox.Selected)
            {
                SaveAsDefaultAddressCheckbox.Click();
            }
        }

        public void DoNotSaveAsDefaultAddress()
        {
            if (SaveAsDefaultAddressCheckbox.Selected)
            {
                SaveAsDefaultAddressCheckbox.Click();
            }
        }

        public bool AddressConfirmed
        {
            get { return ConfirmedAddress != ""; }
        }

        public string ConfirmedAddress
        {
            get { return Driver.FindElement(Container, Locators.ConfirmedAddressLabel).Text; }
        }

        public class Locators
        {
            public static By Container = By.XPath("//div[@class='try-on-steps shadow-panel']");
            public static By HeightSelect = By.Id("SelectedHeight");
            public static By WeightSelect = By.Id("SelectedWeight");
            public static By CoatSizeSelect = By.Id("SelectedCoatSizeId");
            public static By FirstNameInputBox = By.Id("FirstName");
            public static By LastNameInputBox = By.Id("LastName");
            public static By AddressOneInputBox = By.Id("AddressEditor_NewAddress_Line1");
            public static By AddressTwoInputBox = By.Id("AddressEditor_NewAddress_Line2");
            public static By CityInputBox = By.Id("AddressEditor_NewAddress_City");
            public static By StateSelect = By.Id("AddressEditor_NewAddress_StateCode");
            public static By ZipInputBox = By.Id("AddressEditor_NewAddress_ZipCode");
            public static By ConfirmDeliveryAddressButton = By.Id("ConfirmAddressButton");
            public static By ConfirmDeliveryAddressButtonSpinner = By.XPath("//*[@id='ConfirmAddressButton' and contains(@class, 'spinner')]");
            public static By SaveAsDefaultAddressCheckbox = By.Id("AddressEditor_NewAddressSaveAsDefault");
            public static By ContactNumberInputBox = By.Id("ContactNumber");
            public static By WeddingDateInputBox = By.Id("EventDate");
            public static By PreferredTryOnDateInputBox = By.Id("TryOnDate_Value");
            public static By CollectionDateLabel = By.Id("CollectionDateLabel");
            public static By WeddingDateDatePickerContainer = By.Id("EventDate_dw_pnl_0");
            public static By PreferredDateDatePickerContainer = By.Id("TryOnDate_Value_dw_pnl_0");
            public static By ConfirmedAddressLabel = By.Id("ConfirmedAddressLabel");
            public static By AddressConfirmationSpinner = By.XPath("//*[@class='button secondary-cta floatright large spinner']");
            public static By SuggestedAddressLabel = By.Id("SuggestedAddress");

            public static By ConfirmUserEnteredAddressButton = By.Id("ConfirmUserEnteredAddressButton");
            public static By ConfirmSuggestedAddressButton = By.Id("ConfirmSuggestedAddressButton");

            public static By AddressOneMissingLabel = By.XPath("//span[@data-valmsg-for='AddressEditor.NewAddress.Line1']");
            public static By CityMissingLabel = By.XPath("//span[@data-valmsg-for='AddressEditor.NewAddress.City']");
            public static By StateMissingLabel = By.XPath("//span[@data-valmsg-for='AddressEditor.NewAddress.StateCode']");
            public static By ZipMissingLabel = By.XPath("//span[@data-valmsg-for='AddressEditor.NewAddress.ZipCode']");

            public static By InputNewAddressButton = By.Id("InputNewAddressButton");
        }
    }
}
