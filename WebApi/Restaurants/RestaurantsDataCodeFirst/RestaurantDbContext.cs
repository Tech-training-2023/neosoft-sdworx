using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsDataCodeFirst
{
    public class RestaurantDbContext:DbContext
    {
        // constructor is needed to pass connection string to make connection to the database
        public RestaurantDbContext():base()
        {

        }
        public RestaurantDbContext(DbContextOptions options):base(options)
        {

        }
        //declaring the entities
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-T5LA3TC\\SQLEXPRESS;Initial Catalog=RestaurantDatabase;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property(restaurant => restaurant.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant { Id=1, Name = "Chipotle", City ="London", Postcode = "TR4 YU7", State = "London", Cuisine = "TexMex" });
            modelBuilder.Entity<Review>()
                .Property(review => review.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Review>().HasData(new Review {Id=1, Rating = 4, Description = "Good fast food in Tex mex", RestaurantId = 1 });
        }
    }
}
