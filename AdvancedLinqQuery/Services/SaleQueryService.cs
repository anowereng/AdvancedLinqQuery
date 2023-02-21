using EF_Practices.DTO;
using EF_Practices.Helpers;
using EF_Practices.ReportModel;
using EFGenericsAPI.dbContext;
using Microsoft.EntityFrameworkCore;
using Model.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace EF_Practices.Services
{
    public class SaleQueryService
    {
        private BuisnessContext _context;

        public SaleQueryService(BuisnessContext context)
        {
            this._context = context;
        }

        public async Task<Result<SalesIndividualReport>> SalesIndividualReportAsync(SalesFilterDto salesFilter)
        {
            //|| salesFilter.Keyword.Contains(x.Customer.Name)
            //         || salesFilter.Keyword.Contains(x.Customer.Phone)
            salesFilter.To = salesFilter.To.AddHours(23).AddMinutes(59).AddSeconds(00);
            var query = _context.Sales.Include(x => x.Customer)
                        .Where(x => salesFilter.WarehouseId == null || x.WarehouseId == salesFilter.WarehouseId)
                        .Where(x => x.Created >= salesFilter.From && x.Created <= salesFilter.To);

            if (!string.IsNullOrWhiteSpace(salesFilter.Keyword))
            {
                query = query.Where(
                        x => x.OrderNumber.Contains(salesFilter.Keyword) 
                        || x.CustomerPhone.Contains(salesFilter.Keyword) 
                        || x.CustomerName.Contains(salesFilter.Keyword));
            }
            //.Where(x => 
            //        x.CustomerName.ToLower().Contains(salesFilter.Keyword.ToLower()) ||
            //        x.CustomerPhone.ToLower().Contains(salesFilter.Keyword.ToLower()) ||
            //        x.OrderNumber.ToLower().Contains(salesFilter.Keyword.ToLower())
            //        )
            //.Where(x => salesFilter.Keyword.Contains(x.CustomerPhone) || String.IsNullOrWhiteSpace(salesFilter.Keyword))
            query.Select(a => new SalesIndividualReport
                         {
                             CustomerId = a.Customer.Id,
                             CustomerName = a.CustomerName,
                             CustomerPhone = a.CustomerPhone,
                             DiscountAmount = a.DiscountAmount,
                             PaidAmount = a.PaidAmount,
                             DueAmount = a.DueAmount,
                             OrderId = a.Id,
                             OrderNumber = a.OrderNumber,
                             PayableTotalAmount = a.PayableTotalAmount,
                             TotalAmount = a.TotalAmount
                         });
            var count = await query.LongCountAsync();
            var listResult = await query.PageBy(salesFilter).ToListAsync();
            var result = new Result<SalesIndividualReport> { Results = listResult, Count = count };
            return result;
        }
    }
}
