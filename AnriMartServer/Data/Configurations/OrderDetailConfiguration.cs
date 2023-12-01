// ==========================================================================================
//
// Copyright © 2023 AnriMart
//
// History
// ------------------------------------------------------------------------------------------
// Date         Author      
// ------------------------------------------------------------------------------------------
// 2023.10.23   Loan   
// ==========================================================================================
//
using AnriMartServer.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnriMartServer.Configurations
{
    /// <summary>
    ///  Order - Product Configuration
    /// </summary>
    public class OrderDetailConfiguration : BaseEntityConfiguration<OrderDetailRel>
    {
        public override void Configure (EntityTypeBuilder<OrderDetailRel> builder)
        {
            base.Configure (builder);

            builder.ToTable("orderDetail_tbl");

            builder.HasKey(e => new { e.ProductId, e.OrderId });

            builder.HasOne(e => e.Product)
                  .WithMany(e => e.OrderDetailRel)
                  .HasForeignKey(e => e.ProductId);

            builder.HasOne(e => e.Order)
                  .WithMany(e => e.OrderDetailRel)
                  .HasForeignKey(e => e.OrderId);
        }
    }
}