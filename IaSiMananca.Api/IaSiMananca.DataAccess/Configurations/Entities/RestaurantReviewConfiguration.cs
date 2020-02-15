using IaSiMananca.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IaSiMananca.DataAccess.Configurations.Entities
{
    internal class RestaurantReviewConfiguration : IEntityTypeConfiguration<RestaurantReview>
    {
        public void Configure(EntityTypeBuilder<RestaurantReview> builder)
        {
            builder.ToTable("RestaurantReview");
            builder.HasKey(rr => rr.Id);
            builder.Property(rr => rr.Order).IsRequired().HasMaxLength(100);
            builder.Property(rr => rr.Comment).IsRequired().HasMaxLength(300);
            builder.Property(rr => rr.Rating).IsRequired();
            builder.HasOne(rr => rr.Restaurant).WithMany(r => r.RestaurantReviews).HasForeignKey(rr => rr.RestaurantId);
        }
    }
}
