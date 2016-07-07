using System;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.Sites;

namespace XedoFramework.Model.SupportTools
{
    class UrlBuilder
    {
        public static string GetUrl(Site site, Page page)
        {
            string url;
            switch (site)
            {
                case Site.Xedo:
                    url = Urls.Sites.Xedo;
                    break;
                case Site.XedoPerformance:
                    url = Urls.Sites.XedoPerformance;
                    break;
                default:
                    throw new ArgumentException("This site is not implemented");
            }

            switch (page)
            {
                case Page.Home:
                    return url;
                case Page.OutfitBuilder:
                    return url + Urls.Pages.OutfitBuilder;
                case Page.Collections:
                    return url + Urls.Pages.CollectionsPage;
                case Page.ExclusiveAccess:
                    return url + Urls.Pages.ExclusiveAccessPage;
                case Page.QuickTryOn:
                    return url + Urls.Pages.QuickTryOnPage;
                default:
                    throw new ArgumentException("This site is not implemented");
            }
        }
    }
}
