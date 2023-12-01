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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using AnriMartServer.Entites;

namespace AnriMartServer.Configurations
{
    /// <summary>
    ///  Product Configuration
    /// </summary>
    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void Configure (EntityTypeBuilder<Product> builder)
        {
            base.Configure (builder);   

            builder.ToTable("product_tbl");

            builder.HasOne(e => e.Supplier)
                  .WithMany(e => e.Products)
                  .HasForeignKey(e => e.SupplierId);
        }
    }
}