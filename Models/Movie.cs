using System.ComponentModel.DataAnnotations;

namespace Assignment3_jcollins.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string? MovieTitle { get; set; }
        public string? MovieGenre { get; set; }

        public int MovieYear { get; set; }
        public byte[]? MoviePoster { get; set; }

        [Url]
        public string? MovieUrl { get; set; }


    }
}
