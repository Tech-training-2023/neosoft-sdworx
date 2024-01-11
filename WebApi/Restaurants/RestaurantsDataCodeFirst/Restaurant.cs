using System.ComponentModel.DataAnnotations;

namespace RestaurantsDataCodeFirst
{
    public class Restaurant
    {
        public Restaurant()
        {

        }
        // Convention for Primary Key in Code first -> int Id, int <ClassName>Id
        // Data Annotations are the way to contraint your model properties - Range, RegularExpression, Required, StringLength, Validation
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(7)]
        public string Postcode { get; set; }
        public string State { get; set; }
        [Required]
        [StringLength(50)]
        public string  City { get; set; }
        //Navigation Property
        public List<Review> Reviews { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} \n Location: {City} {State} {Postcode}";
        }
    }
}