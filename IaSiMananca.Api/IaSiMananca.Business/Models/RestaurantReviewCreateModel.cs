using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.Business.Models
{
    public class RestaurantReviewCreateModel
    {
        public string NameUser { get; set; }
        public string Order { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CommentDate { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
