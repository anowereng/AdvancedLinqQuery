using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Practices.DTO
{
    public class SalesFilterDto : BaseRequestDTO
    {
        public string WarehouseId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; } 

        //public DateTime To
        //{
        //    get { return To; }
        //    set
        //    {
        //        To = To.AddHours(23).AddMinutes(59).AddSeconds(00);
        //    }
        //}
    }
}
