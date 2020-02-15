using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Models
{
    public class RestaurantReviewUpdateModel : EntityBase
    {
        public string NameUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string Order { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
