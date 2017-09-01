using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace URLShortener.WebAPIService.Controllers
{
    public class DecodeController : BaseApiController
    {
        public HttpResponseMessage Get(string key)
        {
            string url;
            if (!DataProvider.GetOriginalUrl(key, out url))
                throw new HttpException(400, "Bad Request");
            
            var response = Request.CreateResponse(HttpStatusCode.Found);
            response.Headers.Location = new Uri(url);
            return response;
        }
    }
}
