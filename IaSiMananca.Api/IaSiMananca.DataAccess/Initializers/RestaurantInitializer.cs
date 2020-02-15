using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IaSiMananca.DataAccess.Initializers
{
    internal class RestaurantInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            if (dbContext.Restaurants.Any())
            {
                return;
            }

            dbContext.Restaurants.AddRange(new List<Restaurant>
            {
                new Restaurant
                {
                    Id = new Guid("6d29f24e-55b5-4b11-b2d8-3d6f3aa0a037"),
                    Name = "Class",
                    Type = "Fast-Food",
                    Address = "Bd-ul Tudor Vladimirescu, camin T17, parter",
                    Website = "www.classiasi.ro",
                    PhoneNumber = "0730.200.222",
                    OpeningClosingTime = "10:00-22:00",

                },

                new Restaurant
                {
                    Id = new Guid("106446f0-bdfa-41fb-b95b-1030076c6e92"),
                    Name = "Dionisos Restaurant",
                    Type = "Greek",
                    Address = "Str. Smardan, nr.1 (intersectia Bucsinescu)",
                    Website = "www.dionisosking.ro",
                    PhoneNumber = "0753.010.101",
                        Rating = 3.8
                },
                new Restaurant
                {
                    Id=new Guid("4e2869b6-e33d-41b6-aba6-28f02934c883"),
                    Name="Carul cu burgeri",
                    Type="Burgeri",
                    Address ="Bulevardul Carol I, nr. 11, Iasi",
                    Website="",
                    PhoneNumber ="",
                    OpeningClosingTime="10:00 - 22:00"
                },
                 new Restaurant
                {
                    Id=new Guid("ac705be3-0a90-4207-8511-e27c3374458a"),
                    Name="Greek Taverna Souflaki",
                    Type="Quick Service Restaurant Greceasca Bucatarie Italiana Mancare Romaneasca Bucatarie Internationala",
                    Address ="Bulevardul Nicolae Iorga, nr.4A, Iasi",
                    Website="",
                    PhoneNumber ="",
                    OpeningClosingTime="10:00 - 22:00"
                },
                  new Restaurant
                {
                    Id=new Guid("16d5305f-225f-4b40-8669-9de95e7d35e7"),
                    Name="Sushi Ya (Iasi)",
                    Type="Bucatarie Internationala Sushi Bucatarie Japoneza",
                    Address ="Strada Palas, nr. 7A, Iasi",
                    Website="",
                    PhoneNumber ="",
                    OpeningClosingTime="10:00 - 22:00"
                },
                   new Restaurant
                {
                    Id=new Guid("0fcf1d83-757f-4eb0-ac7c-a8ddc1819e37"),
                    Name="Wok Up",
                    Type="Fructe de mare Bucatarie Internationala Vegetariana Asiatica Carne",
                    Address ="Strada Vasile Alecsandri, nr. 7/11, Iasi",
                    Website="",
                    PhoneNumber ="",
                    OpeningClosingTime="10:00 - 22:00"
                }

            });

            dbContext.SaveChanges();
        }
    }
}
