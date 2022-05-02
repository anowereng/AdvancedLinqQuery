using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Practices.ReportModel
{
    public class MonthlySalesOverviewReport
    {
        public double AverageOrderAmount { get; set; }
        public double CostAmount { get; set; }
        public string Month { get; set; }
        public double DueAmount { get; set; }
        public double NewCustomersCount { get; set; }
        public double OrderCount { get; set; }
        public double PaidAmount { get; set; }
        public double PayableAmount { get; set; }
        public double ProductAmount { get; set; }
        public double TotalAmount { get; set; }

    }
}
