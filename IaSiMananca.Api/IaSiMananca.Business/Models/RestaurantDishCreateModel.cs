using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Models
{
    public class RestaurantDishCreateModel
    {
        public string DishName { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
