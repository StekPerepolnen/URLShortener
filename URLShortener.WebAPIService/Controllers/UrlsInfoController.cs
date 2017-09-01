using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using URLShortener.WebAPIService.DataAccess;
using URLShortener.WebAPIService.Models;

namespace URLShortener.WebAPIService.Controllers
{
    public class UrlsInfoController : BaseApiController
    {
        public IEnumerable<UrlInfo> Get()
        {
            return DataProvider.GetUrlsInfoList();
        }
    }
}
