using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WestPharma.Foundation.ExternalWebRequests.Services
{
    public class JsonResponse
    {
        /// <summary>
        /// TODO:
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// TODO:
        /// </summary>
        public string Response { get; set; }
        /// <summary>
        /// TODO:
        /// </summary>
        public List<Cookie> CookieContainerList { get; set; }
        /// <summary>
        /// TODO:
        /// </summary>
        public CookieContainer CookieCollection { get; set; }
    }
}