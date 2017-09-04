using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLShortener.DAOService;

namespace URLShortener.Utils
{
    public class UrlShortener : IUrlShortener
    {
        private IShortUrlDataProvider _dataProvider;

        public IShortUrlDataProvider DataProvider { get { return _dataProvider; } }

        private IUrlKeyGenerator _urlKeyGenerator;

        public IUrlKeyGenerator UrlKeyGenerator { get { return _urlKeyGenerator; } }

        public UrlShortener(IShortUrlDataProvider dataProvider, IUrlKeyGenerator codeMakingStrategy)
        {
            _dataProvider = dataProvider;
            _urlKeyGenerator = codeMakingStrategy;
        }

        public string Encode(string url)
        {
            string key = DataProvider.GetKeyByUrl(url);
            if (key != null)
                return key;
            
            do
            {
                key = UrlKeyGenerator.Next();
            } while (DataProvider.CheckKeyExists(key));
            DataProvider.SaveParsedUrl(url, key);

            return key;
        }

        public bool TryDecode(string key, out string url)
        {
            var parsedUrl = DataProvider.GetUrlByKey(key);
            if (parsedUrl == null)
            {
                url = null;
                return false;
            }

            url = parsedUrl;
            return true;
        }
    }
}
