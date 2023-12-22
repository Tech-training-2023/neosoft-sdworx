using Microsoft.EntityFrameworkCore;
using RestaurantsData.Entities;

namespace RestaurantsData
{
    public class RestaurantRepository : IRestaurantRepository
    {
        // referes to database and perform all operations on it
        RestaurantDbContext context = new RestaurantDbContext();
        public IQueryable<Restaurant> GetAllRestaurants()
        {
            return context.Restaurants.Include(r=>r.Reviews);
        }
    }
}