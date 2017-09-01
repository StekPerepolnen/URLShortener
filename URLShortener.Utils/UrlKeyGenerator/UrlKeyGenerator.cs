using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace URLShortener.Utils
{
    public class UrlKeyGenerator : IUrlKeyGenerator
    {
        public static readonly string abc = "abcdefghijklmnopqrstuvwxyz0123456789";
        public static readonly int abcLength = abc.Length;
        
        private string _lastCode = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seed">The code to start the generation</param>
        /// <param name="codeLength">Start code length</param>
        public UrlKeyGenerator(string seed, int codeLength)
        {
            _lastCode = seed != null && seed.Length >= codeLength ? seed : GetFirstCode(codeLength);
        }

        /// <summary>
        /// Get next alphabetical code
        /// </summary>
        /// <returns></returns>
        public string Next()
        {
            var next = _lastCode.ToList();

            var isPositionOverflow = true;
            var index = _lastCode.Length - 1;

            while (index >= 0 && isPositionOverflow)
            {

                var abcIndex = abc.IndexOf(next[index]) + 1;

                isPositionOverflow = abcIndex >= abcLength;
                if (isPositionOverflow)
                    abcIndex = 0;
                next[index] = abc[abcIndex];

                index--;
            }

            if (index < 0 && isPositionOverflow)
            {
                next.Insert(0, abc[0]);
            }

            _lastCode = String.Concat(next);
            return _lastCode;
        }

        private string GetFirstCode(int firstCodeLength)
        {
            var next = "";
            for (int i = 0; i < firstCodeLength - 1; i++)
                next += abc.Last();
            
            return next;
        }
    }
}
