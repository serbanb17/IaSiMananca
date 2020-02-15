using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Entities
{
    public class RestaurantDish : EntityBase
    {
        public string DishName { get; set; }

        public string Category { get; set; }

        public string Ingredients { get; set; }

        public double Price { get; set; }

        public int Weight { get; set; }

        public Guid RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }


    }
}
