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

namespace AnriMartServer.Services;

public class OrderDetailService : BaseService<OrderDetailRel>
{
    /// <summary>
    ///  Constructor
    /// </summary>
    /// <param name="provider">Services provider</param>
    /// <param name="context">Project DB context</param>
    public OrderDetailService(IServiceProvider provider, DBContext context) : base(provider, context)
    {
    }
}