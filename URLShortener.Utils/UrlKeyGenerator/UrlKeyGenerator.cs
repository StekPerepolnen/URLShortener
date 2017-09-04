using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace URLShortener.Utils
{
    public partial class UrlKeyGenerator : IUrlKeyGenerator
    {
        private string _abc = "abcdefghijklmnopqrstuvwxyz0123456789";
        private string _key = null;

        private UrlKeyGenerator()
        {
        }

        /// <summary>
        /// Get next alphabetical code
        /// </summary>
        /// <returns></returns>
        public string Next()
        {
            var selectedKey = _key;
            _key = GenerateNextKey(_key);
            return selectedKey;
        }

        private string GenerateNextKey(string key)
        {
            var next = key.ToList();

            var isPositionOverflow = true;
            var index = key.Length - 1;

            while (index >= 0 && isPositionOverflow)
            {

                var abcIndex = _abc.IndexOf(next[index]) + 1;

                isPositionOverflow = abcIndex >= _abc.Length || abcIndex < 0;
                if (isPositionOverflow)
                    abcIndex = 0;
                next[index] = _abc[abcIndex];

                index--;
            }

            if (index < 0 && isPositionOverflow)
            {
                next.Insert(0, _abc[0]);
            }

            return String.Concat(next);
        }

        public static UrlKeyGeneratorBuilder Create()
        {
            return new UrlKeyGeneratorBuilder();
        }
    }
}
