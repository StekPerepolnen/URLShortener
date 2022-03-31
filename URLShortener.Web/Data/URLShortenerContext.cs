#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using URLShortener.Web.Models;

namespace URLShortener.Web.Data
{
    public class URLShortenerContext : DbContext
    {
        public URLShortenerContext (DbContextOptions<URLShortenerContext> options)
            : base(options)
        {
        }

        public DbSet<URLShortener.Web.Models.ShortUrlModel> ShortUrls { get; set; }
    }
}
