using System.ComponentModel.DataAnnotations;
    public class Url
    {
        public string UrlId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [StringLength(2000)]
        public string OriginalUrl { get; set; }
        [Required]
        [StringLength(50)]
        public string ShortenedUrl { get; set; }
    }
    //     public class UrlShortenerContext : DbContext
    // {
    //     public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options)
    //     {
    //     }
    //     public DbSet<Url> Urls { get; set; }
    //     public DbSet<Url> Urls { get; set; }
    // }