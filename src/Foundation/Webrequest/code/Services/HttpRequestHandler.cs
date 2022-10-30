using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WestPharma.Foundation.ExternalWebRequests.Services
{
    public class HttpRequestHandler : IHttpRequestHandler
    {
        /// <summary>
        /// Post request to url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResponse JsonPost(string url, string data, bool enableSecurityProtocol = false)
        {
            JsonResponse response = new JsonResponse();
            response.StatusCode = HttpStatusCode.OK;
            try
            {
                //Post Method
                using (WebClient client = new WebClient())
                {
                    client.Headers["Content-Type"] = "application/json";
                    client.Proxy = WebRequest.DefaultWebProxy;
                    //Set the proxy for web client
                    //obtain the response from Post Method
                    string responseString = client.UploadString(url, "POST", data);
                    response.Response = responseString;
                }
            }
            catch (WebException webEx)
            {
                response.StatusCode = ((HttpWebResponse)webEx.Response).StatusCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        /// <summary>
        /// get request to url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns
        public JsonResponse JsonGet(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = new JsonResponse();
            request.Method = "GET";
            var content = string.Empty;

            var webResponse = (HttpWebResponse)request.GetResponse();
           
            response.StatusCode = webResponse.StatusCode;
            using (webResponse)
            {
                using (var stream = webResponse.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        response.Response = sr.ReadToEnd();
                    }
                }
            }
            return response;
        }
    }
}