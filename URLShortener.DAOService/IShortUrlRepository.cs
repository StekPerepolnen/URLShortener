using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.DAOService
{
    public interface IShortUrlRepository
    {
        List<ParsedUrl> GetParsedUrlsList();

        ParsedUrl GetParsedUrlByName(string name);

        ParsedUrl GetParsedUrlByKey(string name);

        ParsedUrl SaveParsedUrl(ParsedUrl instance);
    }
}
