using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public interface IUrlShortener
    {
        string Encode(string url);

        bool TryDecode(string url, out string encode);
    }
}
