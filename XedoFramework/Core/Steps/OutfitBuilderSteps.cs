using System.Threading;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class OutfitBuilderSteps : StepBase
    {
        [Then(@"I can test all the outfit tech")]
        public void ThenICanTestAllTheOutfitTech()
        {
            OutfitBuilderPage.ChooserPanel.WaistcoatChooser.SelectItemByName("Allure Tan Suit Vest");
            Thread.Sleep(2000);
            OutfitBuilderPage.ChooserPanel.WaistcoatChooser.SelectItemByName("Allure Black Cummerbund");
            Thread.Sleep(2000);
            OutfitBuilderPage.ChooserPanel.AccessoryChooser.SelectItemByName("Black Patent Shoe");
            Thread.Sleep(2000);
            OutfitBuilderPage.ChooserPanel.ShirtChooser.SelectItemByName("White Polycotton Pleated Laydown Collar Shirt");
            Thread.Sleep(2000);
        }

    }
}
