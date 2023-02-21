using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Practices.Services;
using EFGenericsAPI.dbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Practices.Controllers
{
    public class SaleController : BaseController
    {
        private SaleServices _services;
        public SaleController(BuisnessContext context) => _services = new SaleServices(context);

        [HttpGet("GetAllDamages")]
        public async Task<ActionResult> GetAllDamages()
        {
            var result = await _services.GetAllDamages();
            return Ok(result);
        }

        [HttpGet("GetAllDamageProducts")]
        public async Task<ActionResult> GetAllDamageProducts()
        {
            var result = await _services.GetAllDamageProducts();
            return Ok(result);
        }

        [HttpGet("GetCompleteOrders")]
        public async Task<ActionResult> GetCompleteOrders()
        {
            var result = await _services.GetSaleStates();
            return Ok(result);
        }
    }
}
