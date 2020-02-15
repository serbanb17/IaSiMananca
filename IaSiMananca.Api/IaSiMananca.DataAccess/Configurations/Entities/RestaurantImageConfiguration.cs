using IaSiMananca.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Configurations.Entities
{
    internal class RestaurantImageConfiguration : IEntityTypeConfiguration<RestaurantImage>
    {
        public void Configure(EntityTypeBuilder<RestaurantImage> builder)
        {
            builder.ToTable("RestaurantImage");
            builder.HasKey(ri => ri.Id);
            builder.HasOne(ri => ri.Restaurant).WithMany(r => r.RestaurantImages).HasForeignKey(ri => ri.RestaurantId);
        }
    }
}
