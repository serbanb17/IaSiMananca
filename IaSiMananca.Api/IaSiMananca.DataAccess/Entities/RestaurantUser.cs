using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Entities
{
    public class RestaurantUser : EntityBase
    {
        public enum PrivilegeValues { None, Admin }

        public string User { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public PrivilegeValues? Privilege { get; set; }

        public Nullable<Guid> RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
