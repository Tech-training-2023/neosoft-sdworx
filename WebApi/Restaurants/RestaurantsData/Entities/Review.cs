using System;
using System.Collections.Generic;

namespace RestaurantsData.Entities
{
    public partial class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string? Decription { get; set; }
        public int? RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
    }
}
