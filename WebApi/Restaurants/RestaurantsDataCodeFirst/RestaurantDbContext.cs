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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property(restaurant => restaurant.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Review>()
                .Property(review => review.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
