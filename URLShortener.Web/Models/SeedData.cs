using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using URLShortener.Web.Data;
using System;
using System.Linq;
using URLShortener.Web.Models;

namespace URLShortener.Web.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new URLShortenerContext(
                serviceProvider.GetRequiredService<DbContextOptions<URLShortenerContext>>()))
            {
                // Look for any movies.
                if (context.ShortUrls.Any())
                {
                    return;   // DB has been seeded
                }

                context.ShortUrls.AddRange(
                    new ShortUrlModel
                    {
                        Origin = "https://test.com",
                        Short = "https://localhost:7097/urls?ghff5h"
                    },
                    new ShortUrlModel
                    {
                        Origin = "https://localhost:7097/ShortUrl",
                        Short = "https://localhost:7097/urls?asdf4d"
                    },
                    new ShortUrlModel
                    {
                        Origin = "https://softcatalog.info/ru/article/fayl-mdf-chto-eto-i-chem-otkryt-mdf-na-pk",
                        Short = "https://localhost:7097/urls?basdf4"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}