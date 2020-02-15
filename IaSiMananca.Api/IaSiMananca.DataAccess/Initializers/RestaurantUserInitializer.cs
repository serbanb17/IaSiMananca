using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IaSiMananca.DataAccess.Initializers
{
    internal class RestaurantUserInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            if (dbContext.RestaurantUsers.Any())
            {
                return;
            }

            dbContext.RestaurantUsers.AddRange(new List<RestaurantUser>
            {
                new RestaurantUser
                {
                    Id = Guid.NewGuid(),
                    User = "ClassAdmin",
                    Password = "ClassAdmin2018",
                    Email = "ClassFastFood@gmail.com",
                    Privilege = RestaurantUser.PrivilegeValues.Admin,
                    RestaurantId = new Guid("6d29f24e-55b5-4b11-b2d8-3d6f3aa0a037")
                },
                new RestaurantUser
                {
                    Id = Guid.NewGuid(),
                    User = "DionisosAdmin",
                    Password = "DionisosAdmin2018",
                    Email = "DionisosRestaurant@gmail.com",
                    Privilege = RestaurantUser.PrivilegeValues.Admin,
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")
                },
                 new RestaurantUser
                {
                    Id = Guid.NewGuid(),
                    User = "Roxana",
                    Password = "parola123",
                    Email = "roxanapn@gmail.com",
                    Privilege = RestaurantUser.PrivilegeValues.None
                }
            });
            dbContext.SaveChanges();
        }
    }
}
