using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Foundation.ExternalWebRequests.Services
{
    public interface IHttpRequestHandler
    {
        JsonResponse JsonGet(string url);
        JsonResponse JsonPost(string url, string data, bool enableSecurityProtocol = false);
    }
}