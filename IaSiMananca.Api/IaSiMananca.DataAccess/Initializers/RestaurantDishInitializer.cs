using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IaSiMananca.DataAccess.Initializers
{
    internal class RestaurantDishInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            if (dbContext.RestaurantDishes.Any())
            {
                return;
            }

            dbContext.RestaurantDishes.AddRange(new List<RestaurantDish>
            {
                new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Shaorma la lipie",
                    Category = "Shaorma",
                    Weight = 450,
                    Price = 15,
                    Ingredients = "piept de pui, cartofi prajiti, varza, castraveti murati, maioneza cu usturoi, ketchup, lipie",
                    RestaurantId = new Guid("6d29f24e-55b5-4b11-b2d8-3d6f3aa0a037")

                },
                new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Crispy portie",
                    Category = "Portii",
                    Weight = 560,
                    Price = 19,
                    Ingredients = "Carne pui, Cartofi prajiti, Salata de varza, Rosii, Castraveti, Sos cocktail, Paine",
                    RestaurantId = new Guid("6d29f24e-55b5-4b11-b2d8-3d6f3aa0a037")
                },
                new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Paidaki de miel",
                    Category = "Specialitati",
                    Weight =100,
                    Price = 16,
                    Ingredients = "Coaste de miel la gratar, oregano, lamaie",
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")

                },
                new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Creveti la gratar",
                    Category = "Fructe de mare",
                    Weight = 100,
                    Price = 15,
                    Ingredients = "Creveti, sos lemonato, lamaie",
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")
                },
                 new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Baby Ultimate",
                    Category = "Preparate",
                    Weight = 235,
                    Price = 14.5,
                    Ingredients = "chifla cu susan, carne de vita, branza cheddar, bacon, ou, castraveti murati, rosii, sos de maioneza cu usturoi, sos cocktail",
                    RestaurantId = new Guid("4e2869b6-e33d-41b6-aba6-28f02934c883")
                },
                  new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Chicken Royale",
                    Category = "Preparate",
                    Weight = 270,
                    Price = 13,
                    Ingredients = "chiflă cu mac și susan, salată coleslaw, sos de maioneză cu usturoi, sos cocktail, file din piept de pui crispy, roșii",
                    RestaurantId = new Guid("4e2869b6-e33d-41b6-aba6-28f02934c883")
                },
                   new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Cheeseburger",
                    Category = "Preparate",
                    Weight = 250,
                    Price = 13.5,
                    Ingredients = "Creveti, sos lemonato, lamaie",
                    RestaurantId = new Guid("4e2869b6-e33d-41b6-aba6-28f02934c883")
                },
                    new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Taitei din orez cu pui si legume",
                    Category = "TAITEI DIN OREZ / RICE NOODLES",
                    Weight = 400,
                    Price = 18,
                    Ingredients = "pui, taitei din orez, ou, morcovi, varza, ceapa, dovlecei, telina, sos de soia, sos de alune, sos de stridii - 40",
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")
                },
                       new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Crispy de pui cu susan",
                    Category = "TAITEI DIN OREZ / RICE NOODLES",
                    Weight = 350,
                    Price = 15,
                    Ingredients = "susan, piept de pui, condimente vietnameze, pesmet, turmeric, ou; 5 buc",
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")
                },
                          new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Orez Jasmin cu legume si porc",
                    Category = "Orez",
                    Weight = 400,
                    Price = 20,
                    Ingredients = "orez jasmin, ou, porc, morcovi, varza, ceapa, dovlecei, telina, sos de soia, sos de alune, sos de stridii ",
                    RestaurantId = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92")
                },
                             new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Kebab la farfurie",
                    Category = "SPECIFIC GRECESC",
                    Weight = 470,
                    Price = 28,
                    Ingredients = "3 kebab carne de miel, 2 pita greceasca, rosie coapta, feta, ceapa rosie, patrunjel -",
                    RestaurantId = new Guid("ac705be3-0a90-4207-8511-e27c3374458a")
                },
                       new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Tochitura moldoveneasca",
                    Category = "TRADITIONAL ROMANESC",
                    Weight = 400,
                    Price = 20,
                    Ingredients = "ceafa de porc, carnati, ou, branza, mamaliguta",
                    RestaurantId = new Guid("ac705be3-0a90-4207-8511-e27c3374458a")
                },
                          new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Paste Carbonara",
                    Category = "Paste",
                    Weight = 400,
                    Price = 18,
                    Ingredients = "paste, bacon, ceapa, smantana, ou, mozzarella",
                    RestaurantId = new Guid("ac705be3-0a90-4207-8511-e27c3374458a")
                },
                                         new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Sake Sashimi - 4 buc",
                    Category = "Sashimi",
                    Weight = 50,
                    Price = 17,
                    Ingredients = "Somon proaspăt",
                    RestaurantId = new Guid("16d5305f-225f-4b40-8669-9de95e7d35e7")
                },
                       new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Maguro Nigiri",
                    Category = "Nigiri",
                    Weight = 60,
                    Price = 16,
                    Ingredients = "Orez cu ton ",
                    RestaurantId = new Guid("16d5305f-225f-4b40-8669-9de95e7d35e7")
                },
                          new RestaurantDish
                {
                    Id = Guid.NewGuid(),
                    DishName = "Supa Miso cu peste",
                    Category = "Supe",
                    Weight = 200,
                    Price = 15,
                    Ingredients = "Alge, ceapă, somon, ton, pește de unt",
                    RestaurantId = new Guid("16d5305f-225f-4b40-8669-9de95e7d35e7")
                },

            });

            dbContext.SaveChanges();
        }
    }
}
