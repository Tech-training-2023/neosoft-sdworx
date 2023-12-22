using System;
using System.Collections.Generic;

namespace RestaurantsData.Entities
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Postcode { get; set; } = null!;
        public string? State { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
