using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Cuisine
    {
        public int CuisineId { get; set; }
        public string CuisineName { get;  set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}