using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Foundation.ExternalWebRequests.Services;

namespace WestPharma.Feature.FeedImport.Services
{
    public interface IFeedImportService
    {
        JsonResponse ImportFeedData();
    }
}