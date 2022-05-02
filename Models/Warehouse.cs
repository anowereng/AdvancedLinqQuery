using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practices.Models
{
    public class Warehouse : ShopChild
    {
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string Area { get; set; }

        public string District { get; set; }

        public bool IsMain { get; set; }

        public WarehouseType WarehouseType { get; set; }
    }
}