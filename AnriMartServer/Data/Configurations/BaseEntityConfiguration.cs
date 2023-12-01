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
    ///  Shared Entity Configuration
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        ///  Default register primary key
        /// </summary>
        /// <param name="builder">Model builer entity</param>
        public virtual void Configure (EntityTypeBuilder<TEntity> builder)
        {
            var generateIdName = $"{typeof(TEntity).Name}Id";

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName(generateIdName);
        }
    }
}