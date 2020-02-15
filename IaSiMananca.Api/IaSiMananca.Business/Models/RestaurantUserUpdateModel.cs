using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static IaSiMananca.DataAccess.Entities.RestaurantUser;

namespace IaSiMananca.Business.Models
{
    public class RestaurantUserUpdateModel : EntityBase
    {
        public string User { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public PrivilegeValues Privilege { get; set; }

        public Guid RestaurantId { get; set; }
    }
}
