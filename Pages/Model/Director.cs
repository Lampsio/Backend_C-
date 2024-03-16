using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Movie.Pages.Model
{
    public class Director
    {
        public int DirectorId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]

        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
