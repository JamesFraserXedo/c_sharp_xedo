using System;
using XedoFramework.Core.Steps.StepsSupport;
using XedoFramework.Model.Sites;

namespace XedoFramework.Model.SupportTools
{
    class UrlBuilder
    {
        public static string GetUrl(Site site, Page page)
        {
            string url = null;
            switch (site)
            {
                case Site.Xedo:
                    switch (page)
                    {
                        case Page.Home:
                            url = Urls.Xedo.HomePage;
                            break;
                        case Page.ExclusiveAccess:
                            url = Urls.Xedo.ExclusiveAccessPage;
                            break;
                        case Page.QuickTryOn:
                            url = Urls.Xedo.QuickTryOnPage;
                            break;
                        case Page.OutfitBuilder:
                            url = Urls.Xedo.OutfitBuilder;
                            break;
                        case Page.Collections:
                            url = Urls.Xedo.CollectionsPage;
                            break;
                    }
                    break;
            }

            if (url == null)
            {
                throw new ArgumentException("Must be a valid site and page definition");
            }
            return url;
            
        }
    }
}
