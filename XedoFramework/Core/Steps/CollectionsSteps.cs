using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class CollectionsSteps : StepBase
    {
        [When(@"I select a collection outfit")]
        public void WhenISelectACollectionOutfit()
        {
            CollectionsPage.Outfits.First().Select();
        }
    }
}
