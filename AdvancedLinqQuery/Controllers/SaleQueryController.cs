using EF_Practices.DTO;
using EF_Practices.Services;
using EFGenericsAPI.dbContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Practices.Controllers
{
    public class SaleQueryController : BaseController
    {
        private SaleQueryService _services;
        public SaleQueryController(BuisnessContext context) => _services = new SaleQueryService(context);

        [HttpGet("SalesIndividualReport")]
        public async Task<IActionResult> SalesIndividualReportAsync([FromQuery] SalesFilterDto salesFilter)
        {
            try
            {
                var result = await _services.SalesIndividualReportAsync(salesFilter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
