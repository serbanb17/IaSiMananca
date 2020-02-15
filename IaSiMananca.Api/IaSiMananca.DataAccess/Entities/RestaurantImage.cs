using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Entities
{
    public class RestaurantImage : EntityBase
    {
        public Guid RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }

        public string Path { get; set; }
    }
}
