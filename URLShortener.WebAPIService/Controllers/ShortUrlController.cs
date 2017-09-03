using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using URLShortener.WebAPIService.Models;

namespace URLShortener.WebAPIService.Controllers
{
    public class ShortUrlController : BaseApiController
    {
        public string Post(string url)
        {
            return DataProvider.GetShortUrl(url);
        }
    }
}