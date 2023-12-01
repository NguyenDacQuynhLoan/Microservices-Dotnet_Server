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
namespace AnriMartServer.Entites
{
    /// <summary>
    ///  Product Entity
    /// </summary>
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public bool IsDiscount { get; set; }

        public decimal? DiscountPercent { get; set; }

        public uint SupplierId { get; set; }

        public Supplier? Supplier { get; set; }

        public ICollection<OrderDetailRel> OrderDetailRel { get; set; }

        public Product ()
        {
            this.OrderDetailRel = new HashSet<OrderDetailRel>( );
        }
    }
}