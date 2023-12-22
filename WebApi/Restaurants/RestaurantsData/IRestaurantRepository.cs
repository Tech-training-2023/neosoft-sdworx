using RestaurantsData.Entities;

namespace RestaurantsData
{
    public interface IRestaurantRepository
    {
        IQueryable<Restaurant> GetAllRestaurants();
    }
}
