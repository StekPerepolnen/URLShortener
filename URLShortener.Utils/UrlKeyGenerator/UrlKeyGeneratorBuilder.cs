using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public class UrlKeyGeneratorBuilder : IUrlKeyGeneratorBuilder
    {
        private string StartCode { get; set; }

        private int StartLength { get; set; }

        public IUrlKeyGeneratorBuilder StartWithSeed(string code)
        {
            StartCode = code;
            return this;
        }

        public IUrlKeyGeneratorBuilder StartWithLength(int length)
        {
            StartLength = length;
            return this;
        }

        public IUrlKeyGenerator Build()
        {
            return new UrlKeyGenerator(StartCode, StartLength);
        }
    }
}
