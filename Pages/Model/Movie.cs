﻿using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json.Serialization;

namespace Movie.Pages.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]

        public string Title { get; set; }
        public string Genre { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }

        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }

        [JsonIgnore]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
