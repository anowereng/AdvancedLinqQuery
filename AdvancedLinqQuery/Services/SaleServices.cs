using EF_Practices.Models;
using EFGenericsAPI.dbContext;
using Microsoft.EntityFrameworkCore;
using Model.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Practices.Services
{
    public class SaleServices
    {
        private BuisnessContext _db;
        public SaleServices(BuisnessContext db)
        {
            _db = db;
        }

        public async Task<List<NameValue>> GetAllDamages()
        {
            var result = await _db.Sales.Include(y => y.SaleDetails)
                        .Where(z => z.SaleDetails.Any(x=>x.SaleDetailType == SaleDetailType.Damage))
                        .Select(y=> new NameValue { Name =  y.OrderNumber, Value =  y.SaleDetails.Sum(b=> b.Quantity).ToString() })
                        .ToListAsync();
            return result;
        }
        public async Task<List<NameValue>> GetAllDamageProducts()
        {
            var result = await _db.Sales.Include(y => y.SaleDetails).ThenInclude(m=>m.ProductDetail)
                        .Where(z => z.SaleDetails.Any(x => x.SaleDetailType == SaleDetailType.Damage))
                        .Select(y => new NameValue { Name = y.OrderNumber, Value =  y.SaleDetails.Single().ProductDetail.Name })
                        .ToListAsync();
            return result;
        }
        public async Task<List<NameValue>> GetSaleStates()
        {
            var startDate = Convert.ToDateTime("2021-01-03 00:00:00");
            var endDate = Convert.ToDateTime("2021-01-03 23:59:00");
            var result = await _db.Sales.Include(x => x.SaleStates).
                         Where(y => y.SaleStates.Any(c => c.State == "Completed" && (c.Modified) >= startDate && (c.Modified) <= endDate)).
                         Select(b=> new NameValue { Name =  b.OrderNumber  , Value =  b.SaleStates.Single().Modified.ToString("dd-MMM-yyyy")}).
                         ToListAsync();
            return result;
        }
    }
}
