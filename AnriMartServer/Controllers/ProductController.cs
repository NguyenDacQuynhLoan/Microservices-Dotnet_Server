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

// using AnriMartServer.RedisStack;
using Microsoft.AspNetCore.Mvc;
using AnriMartServer.Services;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using ProductEntity = AnriMartServer.Entites.Product;
using ProductModel = AnriMartServer.Models.Product;

namespace AnriMartServer.Controllers
{
    /// <summary>
    ///  Product Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<ProductModel,ProductEntity,ProductServices>
    {
        private readonly SupplierServices _supplierServices;
        
        private IDistributedCache _redisCache;
        
        private ProductServices _productServices;

        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="productServices">Product Services</param>
        /// <param name="supplierServices">Suppliers Services</param>
        public ProductController( ProductServices productServices , SupplierServices supplierServices,IDistributedCache redisCache) : base(productServices)
        {
            _redisCache = redisCache;
            _productServices = productServices;
            _supplierServices = supplierServices;
        }

        /// <summary>
        ///  Get all product list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var productList = await GetAsync();
            return Ok(productList);
        }

        /// <summary>
        ///  Create product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct (ProductModel model )
        {
            var productSupplier = await _supplierServices.SearchAsync(e => e.Id.Equals(model.SupplierId));
            
            if (!productSupplier.Any())
            {
                throw new Exception("Supplier is not exist");
            }
            
            var result = await CreateAsync(model);

            var cacheKey = model.Id.ToString();
            var cacheValue = JsonConvert.SerializeObject(model);
            _redisCache.SetString(cacheKey, cacheValue);
            
            var temp = await _redisCache.GetStringAsync(cacheKey);
            return Ok(result);
        }
    }
}