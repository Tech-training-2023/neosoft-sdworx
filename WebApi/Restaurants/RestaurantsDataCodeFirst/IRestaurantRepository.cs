using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsDataCodeFirst
{
    public interface IRestaurantRepository
    {
        IQueryable<Restaurant> GetAllRestaurants();
    }
}
