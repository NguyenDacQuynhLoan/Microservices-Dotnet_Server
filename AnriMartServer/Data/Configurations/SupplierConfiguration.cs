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
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AnriMartServer.Entites;

namespace AnriMartServer.Configurations
{
    /// <summary>
    ///  Supplier Configuration
    /// </summary>
    public class SupplierConfiguration : BaseEntityConfiguration<Supplier>
    {
        public override void Configure (EntityTypeBuilder<Supplier> builder)
        {
            base.Configure (builder);

            builder.ToTable("supplier_tbl");
        }
    }
}