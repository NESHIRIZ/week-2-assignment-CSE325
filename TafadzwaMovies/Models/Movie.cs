using System.ComponentModel.DataAnnotations;

namespace TafadzwaMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public required string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(30)]
        [Required]
        public required string Genre { get; set; }

        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Rating")]
        [StringLength(10)]
        public string? Rating { get; set; }
    }
}
