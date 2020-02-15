using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Models
{
    public class RestaurantDishUpdateModel : EntityBase
    {
        public string DishName { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
