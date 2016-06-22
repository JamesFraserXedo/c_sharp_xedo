using System;
using TechTalk.SpecFlow;
using XedoFramework.Model.Sites;

namespace XedoFramework.Core.Steps.StepsSupport
{
    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation]
        public Site SiteTransform(string siteString)
        {
            foreach (Site site in Enum.GetValues(typeof(Site))) {
                if (String.Equals(siteString, site.ToString()))
                {
                    return site;
                }
            }
            throw new ArgumentException("Could not recognise site type " + siteString);
        }

        [StepArgumentTransformation]
        public Page PageTransform(string pageString)
        {
            foreach (Page page in Enum.GetValues(typeof(Page)))
            {
                if (String.Equals(pageString, page.ToString()))
                {
                    return page;
                }
            }
            throw new ArgumentException("Could not recognise site type " + pageString);
        }

        [StepArgumentTransformation]
        public QuickTryOnAddress QuickTryOnAddressTransform(string quickTryOnAddressString)
        {
            foreach (QuickTryOnAddress quickTryOnAddress in Enum.GetValues(typeof(QuickTryOnAddress)))
            {
                if (String.Equals(quickTryOnAddressString, quickTryOnAddress.ToString()))
                {
                    return quickTryOnAddress;
                }
            }
            throw new ArgumentException("Could not recognise quickTryOnAddress type " + quickTryOnAddressString);
        }
    }
}
