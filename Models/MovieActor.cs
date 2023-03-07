using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_jcollins.Models
{
    public class MovieActor
    {
        public int Id { get; set; }

        [ForeignKey("Actor")]
        public int? ActorId { get; set; }
        public Actor? Actor { get; set; }

        [ForeignKey("Movie")]
        public int? MovieId { get; set; }
        public string? MovieTitle { get; set; }
        public Movie? Movie { get; set; }
    }
}
