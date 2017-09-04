using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public interface IUrlKeyGeneratorBuilder
    {
        IUrlKeyGeneratorBuilder SetAlphabet(string abc);

        IUrlKeyGeneratorBuilder MinLength(int length);

        IUrlKeyGeneratorBuilder PassedKey(string key);

        IUrlKeyGenerator Build();
    }
}
