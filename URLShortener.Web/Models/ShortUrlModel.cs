namespace URLShortener.Web.Models
{
    public class ShortUrlModel
    {
        public int Id { get; set; }
        public string? Origin { get; set; }
        public string? Short { get; set; }
    }
}
