using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Entities
{
    public class Restaurant : EntityBase
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string OpeningClosingTime { get; set; }

        public string Website { get; set; }

        public double Rating { get; set; }

        public ICollection<RestaurantDish> RestaurantDishes { get; set; }

        public ICollection<RestaurantReview> RestaurantReviews { get; set; }

        public ICollection<RestaurantUser> RestaurantUsers { get; set; }

        public ICollection<RestaurantImage> RestaurantImages { get; set; }
        
    }
}
