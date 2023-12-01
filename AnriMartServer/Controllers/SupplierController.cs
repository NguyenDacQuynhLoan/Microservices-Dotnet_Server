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

using AnriMartServer.Models;
using AnriMartServer.Services;
using Microsoft.AspNetCore.Mvc;

using SupplierEntity = AnriMartServer.Entites.Supplier;
// using SupplierModel = AnriMartServer.Models.Supplier;

namespace AnriMartServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : BaseController<Supplier,SupplierEntity,SupplierServices>
    {
        // private SupplierServices _supplierServices;
        //
        // /// <summary>
        // ///  Constructor
        // /// </summary>
        // public SupplierController(SupplierServices supplierServices) : base(supplierServices)
        // {
        //     _supplierServices = supplierServices;
        // }

        private IBaseService<SupplierEntity> _supplierServices;

        /// <summary>
        ///  Constructor
        /// </summary>
        public SupplierController(SupplierServices supplierServices) : base(supplierServices)
        {
            _supplierServices = supplierServices;
        }

        /// <summary>
        ///  Get all product list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            try
            {
                var productList = await _supplierServices.GetAsync();
            
                return Ok(productList);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct (Supplier model )
        {
            // var newProduct = model.MapTo<SupplierEntity>();

            //var modelPropertyValue = modelProperty.SetValue();
            var productList = await CreateAsync(model);
            return Ok(productList);
        }

        //public void demoIndexer ()
        //{
        //    NormalIndexers normalIndexers = new( );
        //    string indexers1 = normalIndexers[3];


        //    GenericIndexers<string> genericIndexers = new( );
        //    string indexers2 = genericIndexers[3];
        //}
    }
}