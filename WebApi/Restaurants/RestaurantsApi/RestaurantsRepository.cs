using RestaurantsApi.Models;

namespace RestaurantsApi
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        void AddRestaurant(Restaurant restaurant);
        void UpdateRestaurant(int id,Restaurant restaurant);
        void DeleteRestaurant(int id);
    }
    public class RestaurantsRepository : IRestaurantRepository
    {
        static List<Restaurant> restaurants = new List<Restaurant>() {
            new Restaurant(){Id=1, Cuisine = "Italian", Name="Japes", Postcode="WA1 2HK", Rating = 5},
            new Restaurant(){Id=2, Cuisine = "Mexican", Name="Tapas", Postcode="PQ1 3GH", Rating = 4.5f},
            new Restaurant(){Id=3, Cuisine = "Indian", Name="1947", Postcode="MK3 4CE", Rating = 4.7f},
            new Restaurant(){Id=4, Cuisine = "Chinese", Name="Bonto Wok", Postcode="MA5 UR7", Rating = 4.2f},
        };

        public void AddRestaurant(Restaurant restaurant)
        {
            if(restaurant != null)
                restaurants.Add(restaurant);
        }

        public void DeleteRestaurant(int id)
        {
            if(id > 0 && id <= restaurants.Count)
                restaurants.RemoveAt(id-1);
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return restaurants;
        }

        public void UpdateRestaurant(int id,Restaurant restaurant)
        {
            var checkForRestaurant=restaurants.Where(r => r.Id == id).FirstOrDefault();
            if (checkForRestaurant != null)
            {
                //restaurants.RemoveAt(id);
                restaurants.Remove(checkForRestaurant);
                restaurants.Add(restaurant);
            }            
        }
    }
}
