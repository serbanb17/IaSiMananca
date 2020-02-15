using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Models
{
    public class RestaurantUserCreateModel
    {
        public string User { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Guid RestaurantId { get; set; }
    }
}
