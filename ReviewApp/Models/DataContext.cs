using Microsoft.EntityFrameworkCore;

namespace ReviewApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; } 
        public DbSet<Reviewer> Reviewers { get; set; }

        //Create seed data for Cars table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Nissan",
                    Model = "Bluebird",
                    Year = 2004,
                    Color = "Red",
                    Country = "Japan",
                    Mileage = "100",
                    Price = 5000,
                    Rating = 3
                },
                 new Car
                 {
                     Id = Guid.NewGuid(),
                     Brand = "Toyota",
                     Model = "Corolla",
                     Year = 2007,
                     Color = "Silver",
                     Country = "Japan",
                     Mileage = "105",
                     Price = 8000,
                     Rating = 4
                 }
                ); ;
        }
    }
}
