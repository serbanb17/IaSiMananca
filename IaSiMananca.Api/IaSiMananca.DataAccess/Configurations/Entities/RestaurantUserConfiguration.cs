using IaSiMananca.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Configurations.Entities
{
    internal class RestaurantUserConfiguration : IEntityTypeConfiguration<RestaurantUser>
    {
        public void Configure(EntityTypeBuilder<RestaurantUser> builder)
        {
            builder.ToTable("RestaurantUser");
            builder.HasKey(ru => ru.Id);
            builder.HasIndex(ru => ru.Email).IsUnique();

            builder.Property(ru => ru.User).IsRequired().HasMaxLength(20);
            builder.Property(ru => ru.Password).IsRequired().HasMaxLength(20);
            builder.Property(ru => ru.Privilege).IsRequired();

            builder.HasOne(ru => ru.Restaurant).WithMany(r => r.RestaurantUsers).HasForeignKey(ru => ru.RestaurantId).IsRequired(false);
        }
    }
}
