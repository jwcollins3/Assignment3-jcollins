using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_jcollins.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string? ActorName { get; set; }
        public string? ActorGender { get; set; }
        public int ActorAge { get; set; }
        public byte[]? ActorPhoto { get; set; }

        [Url]
        public string? ActorUrl { get; set; }


    }
}
