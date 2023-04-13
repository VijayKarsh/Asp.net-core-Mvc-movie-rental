using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Movie_Store.Models
{
    public class Admin
    {

        public int Aid { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        // Foreign key   
        public virtual int Id { get; set; }

        [ForeignKey("Id")]
        public virtual User user { get; set; }

    }
}
