using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Foundation.ExternalWebRequests.Services;

namespace WestPharma.Feature.FeedImport.Services
{
    public class FeedImportService :IFeedImportService
    {
        IHttpRequestHandler _handler;
        public FeedImportService()
        {
            _handler = new HttpRequestHandler();
        }
        /// <summary>
        /// Import data from external APIs
        /// Connected to foundation and external web request called from there
        /// </summary>
        /// <returns></returns>
        public JsonResponse ImportFeedData()
        {
            JsonResponse response = null;
            try
            {
                response = _handler.JsonGet("feedurl");
                
                //TODO: modify the data from response
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}