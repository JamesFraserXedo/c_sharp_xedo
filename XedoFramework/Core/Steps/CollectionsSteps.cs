using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using XedoFramework.Core.Contexts;
using XedoFramework.Core.Steps.StepsSupport;

namespace XedoFramework.Core.Steps
{
    [Binding]
    public class CollectionsSteps : StepBase
    {
        public CollectionsSteps(Context context) : base(context)
        {
        }

        [When(@"I select a collection outfit")]
        public void WhenISelectACollectionOutfit()
        {
            CollectionsPage.Outfits.First().Select();
        }
    }
}
