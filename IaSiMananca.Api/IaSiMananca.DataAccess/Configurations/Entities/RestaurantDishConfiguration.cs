using IaSiMananca.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Configurations.Entities
{
    internal class RestaurantDishConfiguration : IEntityTypeConfiguration<RestaurantDish>
    {
        public void Configure(EntityTypeBuilder<RestaurantDish> builder)
        {
            builder.ToTable("RestaurantDish");
            builder.HasKey(rd => rd.Id);


            builder.Property(rd => rd.DishName).IsRequired().HasMaxLength(100);
            builder.HasOne(rd => rd.Restaurant).WithMany(r => r.RestaurantDishes).HasForeignKey(rd => rd.RestaurantId);
        }
    }
}
