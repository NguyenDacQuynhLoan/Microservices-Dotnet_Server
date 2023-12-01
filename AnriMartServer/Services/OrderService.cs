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
    public class OrderService : BaseService<Order>
    {
        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="provider">Service provider</param>
        /// <param name="context">Project DB context</param>
        public OrderService(IServiceProvider provider, DBContext context) : base(provider, context)
        {
        }
    }
}