using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IaSiMananca.DataAccess.Initializers
{
    internal class RestaurantReviewInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            if (dbContext.RestaurantReviews.Any())
            {
                return;
            }

            dbContext.RestaurantReviews.AddRange(new List<RestaurantReview>
            {
                new RestaurantReview
                {
                    Id = Guid.NewGuid(),
                    NameUser = "Sultan",
                    CommentDate = new DateTime(2018,06,21),
                    Order = "Shaorma la lipie",
                    Comment = "Cea mai buna shaorma din oras!",
                    Rating = 10,
                    RestaurantId = new Guid("6d29f24e-55b5-4b11-b2d8-3d6f3aa0a037")
                },
                new RestaurantReview
                {
                    Id = Guid.NewGuid(),
                    NameUser = "Gigi",
                    CommentDate = new DateTime(2018,06,21),
                    Order = "Paidaki de miel ",
                    Comment = "Habar nu aveam ce este un Paidaki, dar e foarte bun. Recomand.",
                    Rating = 9,
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")
                }
            });
            dbContext.SaveChanges();
        }
    }
}
