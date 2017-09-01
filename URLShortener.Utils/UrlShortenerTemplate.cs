using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLShortener.DAOService;

namespace URLShortener.Utils
{
    public class UrlShortenerTemplate: IUrlShortenerCreator
    {
        public IUrlShortener Create()
        {
            var repo = new ShortUrlRepository();
            var dataProvider = new ShortUrlDataProvider(repo);
            var strategy = (new UrlKeyGeneratorBuilder())
                .StartWithSeed(dataProvider.GetLatestKey())
                .StartWithLength(4)
                .Build();
            var urlShortener = new UrlShortener(dataProvider, strategy);

            return urlShortener;
        }
    }
}
