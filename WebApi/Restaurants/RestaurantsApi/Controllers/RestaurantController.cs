using Microsoft.AspNetCore.Mvc;
using data = RestaurantsDataCodeFirst ;

//using RestaurantsApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        data.IRestaurantRepository repository = new data.RestaurantRepository();
        // GET: api/<RestaurantController>

        [HttpGet(Name ="GetRestaurants")]
        public IQueryable<data.Restaurant> Get()
        {
            return repository.GetAllRestaurants();
        }
        
        // GET api/<RestaurantController>/5
        //[HttpGet("{id}")]
        /*public Restaurant GetRestaurantById(int id)
        {
            return repository.GetAllRestaurants().Where(r => r.Id == id).FirstOrDefault();
        }
        //[HttpGet("{name}")]
        //public Restaurant GetRestaurantByName([FromQuery]string name)
        //{
        //    return repository.GetAllRestaurants().Where(r => r.Name == name).FirstOrDefault();
        //}
        //[HttpGet("{postcode}")]
        //public IEnumerable<Restaurant> GetRestaurantsByPostcode([FromQuery] string postcode)
        //{
        //    return repository.GetAllRestaurants().Where(r => r.Postcode == postcode).ToList();
        //}

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

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteRestaurant(id);
        }*/
    }
}
