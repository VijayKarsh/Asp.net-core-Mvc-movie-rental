using System.ComponentModel.DataAnnotations;

namespace Super_Movie_Store.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Mobile { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsRemember { get; set; }

        public List<Rental> Rentals { get; set; }

    }
}
