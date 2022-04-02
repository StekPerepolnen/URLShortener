using System.ComponentModel.DataAnnotations;

namespace URLShortener.Web.Models
{
    public class ShortUrlModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2048, MinimumLength = 20)]
        public string? Origin { get; set; }

        public string? Short { get; set; }
    }
}
