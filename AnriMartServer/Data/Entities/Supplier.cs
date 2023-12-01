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
    ///  Supplier Entity
    /// </summary>
    public class Supplier : BaseEntity
    {
        public string SupplierName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public ICollection<Product> Products { get; set; }

        public Supplier ()
        {
            this.Products = new HashSet<Product>( );
        }
    }
}