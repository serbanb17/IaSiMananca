using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Models
{
    public class RestaurantUpdateModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string OpeningClosingTime { get; set; }

        public string Website { get; set; }
        
        public double Rating { get; set; }
    }
}
