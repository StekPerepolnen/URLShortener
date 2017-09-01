using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using URLShortener.DAOService;
using URLShortener.Utils;
using URLShortener.WebAPIService.DataAccess;

namespace URLShortener.WebAPIService
{
    public class BaseApiController : ApiController
    {
        private DataProvider _dataProvider;

        public DataProvider DataProvider
        {
            get { return _dataProvider; }
        }

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            var repo = new ShortUrlRepository();
            var urlShortener = (new UrlShortenerTemplate()).Create();
            var baseUrl = controllerContext.Request.RequestUri.GetLeftPart(UriPartial.Authority) + "/";
            _dataProvider = new DataProvider(repo, urlShortener, baseUrl);

            base.Initialize(controllerContext);
        }
    }
}