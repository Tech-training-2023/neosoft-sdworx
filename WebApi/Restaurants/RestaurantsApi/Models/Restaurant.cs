namespace RestaurantsApi.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Cuisine { get; set; }
        public string  Postcode { get; set; }
        public float Rating { get; set; }
    }
}
