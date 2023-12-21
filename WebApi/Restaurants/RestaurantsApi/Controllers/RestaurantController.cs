using Microsoft.AspNetCore.Mvc;
using RestaurantsApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        IRestaurantRepository repository = new RestaurantsRepository();
        // GET: api/<RestaurantController>
        [HttpGet("GetRestaurants")]
        public IEnumerable<Restaurant> Get()
        {
            return repository.GetAllRestaurants();
        }
        
        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public Restaurant Get(int id)
        {
            return repository.GetAllRestaurants().Where(r => r.Id == id).FirstOrDefault();
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] Restaurant r)
        {
            repository.AddRestaurant(r);
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Restaurant r)
        {
            repository.UpdateRestaurant(id,r);
        }

        /*// DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
