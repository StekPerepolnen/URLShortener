using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.DAOService
{
    public class ShortUrlRepository : IShortUrlRepository
    {
        public List<ParsedUrl> GetParsedUrlsList()
        {
            using (var db = new DbShortUrlEntities())
            {
                return db.ParsedUrls.ToList();
            }
        }

        public ParsedUrl GetParsedUrlByName(string name)
        {
            using (var db = new DbShortUrlEntities())
            {
                return db.ParsedUrls.SingleOrDefault(x => x.Name == name);
            }
        }

        public ParsedUrl GetParsedUrlByKey(string key)
        {
            using (var db = new DbShortUrlEntities())
            {
                return db.ParsedUrls.SingleOrDefault(x => x.Key == key);
            }
        }

        public ParsedUrl SaveParsedUrl(ParsedUrl instance)
        {
            using (var db = new DbShortUrlEntities())
            {
                if (instance.Id == 0)
                {
                    db.Entry(instance).State = EntityState.Added;
                    db.SaveChanges();
                }
                else
                {
                    db.Entry(instance).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return instance;
            }
        }
    }
}
