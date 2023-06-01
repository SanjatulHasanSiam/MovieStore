using Microsoft.Build.Framework;

namespace MovieStore.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Releaseyear { get; set; }
        [Required]
        public string? MovieImage { get; set; }
        [Required]
        public string? Cast { get; set; }
        [Required]
        public string? Director { get; set; }
    }
}
