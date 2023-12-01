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
using AnriMartServer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using OrderModel = AnriMartServer.Models.Order;
using OrderEntity = AnriMartServer.Entites.Order;

namespace AnriMartServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController<OrderModel, OrderEntity, OrderService>
    {
        private IDistributedCache _redisCache;
        
        private OrderService _service; 
        
        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="services">Order Services</param>
        public OrderController(OrderService services) : base(services)
        {
            _service = services;
        }

        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<IActionResult> GetOrderPerPage(int pageIndex, int pageSize)
        {
            var result = await _service.GetAsync(pageIndex, pageSize);
            return Ok(result);
        }
    }
}