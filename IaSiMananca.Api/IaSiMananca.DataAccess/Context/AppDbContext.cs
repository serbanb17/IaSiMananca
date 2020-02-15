using IaSiMananca.DataAccess.Configurations.Entities;
using IaSiMananca.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantDish> RestaurantDishes { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
        public DbSet<RestaurantUser> RestaurantUsers { get; set; }
        public DbSet<RestaurantImage> RestaurantImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration (new RestaurantConfiguration());

            modelBuilder.ApplyConfiguration(new RestaurantDishConfiguration());

            modelBuilder.ApplyConfiguration(new RestaurantReviewConfiguration());

            modelBuilder.ApplyConfiguration(new RestaurantUserConfiguration());

            modelBuilder.ApplyConfiguration(new RestaurantImageConfiguration());
        }
    }
}
