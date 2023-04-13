using System.ComponentModel.DataAnnotations;

namespace Super_Movie_Store.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }

        public int UserId { get; set; }


        public string FName { get; set; }

        public string LName { get; set; }

        public DateTime FDate { get; set; }

        public DateTime TDate { get; set; }

    }
}
