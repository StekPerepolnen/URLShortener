using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using URLShortener.DAOService;
using URLShortener.Utils;
using URLShortener.WebAPIService.Models;

namespace URLShortener.WebAPIService.DataAccess
{
    public class DataProvider : IDataProvider
    {
        private IShortUrlRepository _repository;

        public IShortUrlRepository Repository { get { return _repository; } }

        private IUrlShortener _urlShortener;

        public IUrlShortener UrlShortener { get { return _urlShortener; } }

        private string _baseUrl;

        public string BaseUrl { get { return _baseUrl; } }

        public DataProvider(IShortUrlRepository repository, IUrlShortener urlShortener, string baseUrl)
        {
            _repository = repository;
            _urlShortener = urlShortener;
            _baseUrl = baseUrl;
        }

        public List<UrlInfo> GetUrlsInfoList()
        {
            return Repository.GetParsedUrlsList().Select(x => new UrlInfo()
            {
                Id = x.Id,
                Url = x.Name,
                ShortUrl = BaseUrl + x.Key,
                CreateAt = x.CreateAt,
                ClicksCount = x.ClicksCount
            }).ToList();
        }
        
        public string GetShortUrl(string url)
        {
            if (url.StartsWith("http://"))
                url = url.Replace("http://", "");
            if (url.StartsWith("https://"))
                url = url.Replace("https://", "");
            url = "https://" + url;
            return BaseUrl + UrlShortener.Encode(url);
        }

        public bool GetOriginalUrl(string key, out string url)
        {
            if (!UrlShortener.TryDecode(key, out url))
                return false;

            var parsedUrl = Repository.GetParsedUrlByKey(key);
            parsedUrl.ClicksCount++;
            Repository.SaveParsedUrl(parsedUrl);

            return true;
        }
    }
}