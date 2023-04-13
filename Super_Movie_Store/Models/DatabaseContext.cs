using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Super_Movie_Store.Models
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {

    
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Movie> Movie { get; set; }

        public DbSet<Rental>Rentals { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Admin> Admin { get; set; }

    }
}
