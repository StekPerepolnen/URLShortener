using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLShortener.DAOService;

namespace URLShortener.Utils
{
    public class UrlShortenerTemplate: IUrlShortenerTemplate
    {
        public IUrlShortener Create()
        {
            var repo = new ShortUrlRepository();
            var dataProvider = new ShortUrlDataProvider(repo);
            var generator = UrlKeyGenerator.Create()
                .MinLength(4)
                .PassedKey(dataProvider.GetLatestKey())
                .Build();
            var urlShortener = new UrlShortener(dataProvider, generator);

            return urlShortener;
        }
    }
}
