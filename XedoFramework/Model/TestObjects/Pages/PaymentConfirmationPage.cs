using System;
using XedoFramework.Model.SupportTools;
using XedoFramework.Model.TestObjects.Bases;
using XedoFramework.Model.TestObjects.Controls.PaymentConfirmation;

namespace XedoFramework.Model.TestObjects.Pages
{
    class PaymentConfirmationPage : PageBase
    {
        public PaymentConfirmationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public PaymentForm PaymentForm
        {
            get { return new PaymentForm(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(PaymentForm.Locators.Container);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }
    }
}
