using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IaSiMananca.DataAccess.Initializers
{
    internal class RestaurantImageInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            if(dbContext.RestaurantImages.Any())
            {
                return;
            }

            dbContext.RestaurantImages.AddRange(new List<RestaurantImage>
            {
                new RestaurantImage
                {
                    Id = Guid.NewGuid(),
                    RestaurantId = new Guid("6d29f24e-55b5-4b11-b2d8-3d6f3aa0a037"),
                    Path = @"D:\IaSiManacaImages\TestImage"
                },
                new RestaurantImage
                {
                    Id = Guid.NewGuid(),
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92"),
                    Path = @"D:\IaSiManacaImages\TestImage"
                },

            });

            dbContext.SaveChanges();
        }
    }
}
