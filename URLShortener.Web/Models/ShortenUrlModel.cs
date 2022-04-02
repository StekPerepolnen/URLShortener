using System.ComponentModel.DataAnnotations;

namespace URLShortener.Web.Models
{
    public class ShortenUrlModel
    {
        [Required]
        [StringLength(2048, MinimumLength = 20)]
        public string? Origin { get; set; }
    }
}
