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

namespace AnriMartServer.Services
{
    public class ProductServices : BaseService<Product>
    {
        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="provider">Service provider</param>
        /// <param name="context">Project DB Context</param>
        public ProductServices (IServiceProvider provider, DBContext context) : base (provider, context)
        {
        }
    }
}