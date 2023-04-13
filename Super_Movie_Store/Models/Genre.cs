using System.ComponentModel.DataAnnotations;

namespace Super_Movie_Store.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }
}
