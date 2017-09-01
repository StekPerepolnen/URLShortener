using System.Collections.Generic;
using URLShortener.WebAPIService.Models;

namespace URLShortener.WebAPIService.DataAccess
{
    public interface IDataProvider
    {
        bool GetOriginalUrl(string key, out string url);
        string GetShortUrl(string url);
        List<UrlInfo> GetUrlsInfoList();
    }
}