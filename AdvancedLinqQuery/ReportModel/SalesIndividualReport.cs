using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Practices.ReportModel
{
    public class SalesIndividualReport
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public double DiscountAmount { get; set; }
        public double DueAmount { get; set; }
        public double PaidAmount { get; set; }
        public double PayableTotalAmount { get; set; }
        public double TotalAmount { get; set; }
        public string OrderId { get; set; }
        public string OrderNumber { get; set; }

    }
}
