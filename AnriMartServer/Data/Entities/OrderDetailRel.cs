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
    ///  Order - Product Entity
    /// </summary>
    public class OrderDetailRel : BaseEntity
    {
        public uint ProductId { get; set; }

        public Product? Product { get; set; }

        public uint OrderId { get; set; }

        public Order? Order { get; set; }

    }
}
