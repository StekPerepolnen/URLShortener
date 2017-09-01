using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public interface IUrlKeyGeneratorBuilder
    {
        IUrlKeyGeneratorBuilder StartWithLength(int length);

        IUrlKeyGeneratorBuilder StartWithSeed(string code);

        IUrlKeyGenerator Build();
    }
}
