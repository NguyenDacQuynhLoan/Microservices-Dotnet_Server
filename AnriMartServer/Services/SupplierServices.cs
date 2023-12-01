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
    public class SupplierServices : BaseService<Supplier>
    {
        /// <summary>
        ///  Constructor 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="context"></param>
        public SupplierServices (IServiceProvider provider, DBContext context) : base(provider, context)
        {
        }
    }
}