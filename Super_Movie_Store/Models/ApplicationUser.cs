using Microsoft.AspNetCore.Identity;

namespace Super_Movie_Store.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
