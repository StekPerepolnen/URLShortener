using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Utils
{
    public partial class UrlKeyGenerator
    {
        public class UrlKeyGeneratorBuilder : IUrlKeyGeneratorBuilder
        {
            private readonly UrlKeyGenerator _generator;

            public UrlKeyGeneratorBuilder()
            {
                _generator = new UrlKeyGenerator();
            }

            public IUrlKeyGeneratorBuilder SetAlphabet(string abc)
            {
                _generator._abc = abc;
                if (!IsAlphabetContainsKey(_generator._key))
                    _generator._key = null;
                return this;
            }

            public IUrlKeyGeneratorBuilder PassedKey(string key)
            {
                var next = _generator.GenerateNextKey(key);
                ProcessPassedKey(next);
                return this;
            }

            public IUrlKeyGeneratorBuilder MinLength(int length)
            {
                var key = GetDefaultKey(length);
                ProcessPassedKey(key);
                return this;
            }

            private string GetDefaultKey(int length)
            {
                var key = "";
                for (int i = 0; i < length; i++)
                    key += _generator._abc.First();

                return key;
            }

            private void ProcessPassedKey(string key)
            {
                if (_generator._key == null || key.Length > _generator._key.Length)
                {
                    _generator._key = key;
                    return;
                }
                if (_generator._key.Length > key.Length)
                    return;

                if (!IsAlphabetContainsKey(key))
                    return;

                for (int i = 0; i < key.Length; i++)
                    if (_generator._abc.IndexOf(_generator._key[i]) < _generator._abc.IndexOf(key[i]))
                    {
                        _generator._key = key;
                        return;
                    }
                    else if (_generator._abc.IndexOf(_generator._key[i]) > _generator._abc.IndexOf(key[i]))
                        return;
            }

            private bool IsAlphabetContainsKey(string key)
            {
                for (int i = 0; i < key.Length; i++)
                    if (!_generator._abc.Contains(key[i]))
                        return false;

                return true;
            }

            public IUrlKeyGenerator Build()
            {
                return _generator;
            }
        }
    }
}
