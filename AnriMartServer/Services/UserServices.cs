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

public class UserServices : BaseService<User>
{
    /// <summary>
    ///  Constructor
    /// </summary>
    /// <param name="provider">Service Provider</param>d
    /// <param name="context">Db context</param>
    public UserServices(IServiceProvider provider, DBContext context) : base(provider, context)
    {
    }
}