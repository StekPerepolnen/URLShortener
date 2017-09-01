using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.WebAPIService.Models
{
    public class UrlInfo
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public string ShortUrl { get; set; }
        public DateTime CreateAt { get; set; }
        public long ClicksCount { get; set; }
    }
}
