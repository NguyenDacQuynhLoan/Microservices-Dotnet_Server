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
    ///  Order Entity Configuration
    /// </summary>
    public class OrderConfiguration : BaseEntityConfiguration<Order>
    {
        public override void Configure (EntityTypeBuilder<Order> builder)
        {
            base.Configure (builder);

            builder.ToTable("order_tbl");
        }
    }
}