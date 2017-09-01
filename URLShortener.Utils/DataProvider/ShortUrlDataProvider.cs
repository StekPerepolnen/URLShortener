using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLShortener.DAOService;

namespace URLShortener.Utils
{
    public class ShortUrlDataProvider : IShortUrlDataProvider
    {
        private IShortUrlRepository _repository;

        public IShortUrlRepository Repository { get { return _repository; } }
        
        public ShortUrlDataProvider(IShortUrlRepository repository)
        {
            _repository = repository;
        }

        public string GetKeyByUrl(string url)
        {
            return Repository.GetParsedUrlByName(url)?.Key;
        }

        public bool CheckKeyExists(string url)
        {
            return Repository.GetParsedUrlByName(url) != null;
        }

        public string GetLatestKey()
        {
            if (Repository.GetParsedUrlsList().Count == 0)
                return null;

            var urls = Repository.GetParsedUrlsList();
            var lastCreate = urls.Max(x => x.CreateAt);
            return urls.FirstOrDefault(x => x.CreateAt == lastCreate).Key;
        }

        public string GetUrlByKey(string key)
        {
            return Repository.GetParsedUrlByKey(key)?.Name;
        }

        public void SaveParsedUrl(string url, string key)
        {
            Repository.SaveParsedUrl(new ParsedUrl()
            {
                Name = url,
                Key = key,
                CreateAt = DateTime.Now,
                ClicksCount = 0
            });
        }
    }
}
