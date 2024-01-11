using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsDataCodeFirst
{
    public class Review
    {
        public Review()
        {

        }
        public int Id { get; set; }
        [Range(1,5)]
        public decimal Rating { get; set; }
        [StringLength(300)]
        public string  Description { get; set; }
        public int RestaurantId { get; set; }
        public override string ToString()
        {
            return $"\tRating: {Rating} \n\t Description: {Description}";
        }
    }
}
