using Microsoft.EntityFrameworkCore;


namespace RestaurantsDataCodeFirst
{
    public class RestaurantRepository:IRestaurantRepository
    {
        RestaurantDbContext context = new RestaurantDbContext();
        public IQueryable<Restaurant> GetAllRestaurants()
        {
            return context.Restaurants.Include(r => r.Reviews);
        }
    }
}
