using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public interface IShortUrlDataProvider
    {
        string GetKeyByUrl(string url);

        bool CheckKeyExists(string url);

        string GetUrlByKey(string shortUrl);

        void SaveParsedUrl(string url, string shortUrl);
    }
}
