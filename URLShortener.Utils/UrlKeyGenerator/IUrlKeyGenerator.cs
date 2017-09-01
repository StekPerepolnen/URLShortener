using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public interface IUrlKeyGenerator
    {
        string Next();
    }
}
