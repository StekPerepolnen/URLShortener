using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace URLShortener.Utils
{
    public partial class UrlKeyGenerator : IUrlKeyGenerator
    {
        private string _abc;
        private string _key;

        private const string DEFAULT_ALPHABET = "abcdefghijklmnopqrstuvwxyz0123456789";
        private const int DEFAULT_LENGTH = 6;

        public UrlKeyGenerator() : this(DEFAULT_ALPHABET, DEFAULT_LENGTH) { }

        public UrlKeyGenerator(int length) : this(DEFAULT_ALPHABET, length) { }

        public UrlKeyGenerator(string alphabet, int length)
        {
            _abc = alphabet;
            _key = GetDefaultKey(length);
        }

        public UrlKeyGenerator(string key) : this(DEFAULT_ALPHABET, key) { }

        public UrlKeyGenerator(string alphabet, string key)
        {
            _abc = alphabet;
            _key = key;
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

        public static Builder Create()
        {
            return new Builder();
        }

        private string GetDefaultKey(int length)
        {
            var key = "";
            for (int i = 0; i < length; i++)
                key += _abc.First();

            return key;
        }
    }
}
