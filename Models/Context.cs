using Microsoft.EntityFrameworkCore;


namespace LandR.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews {get;set;}

    }
}