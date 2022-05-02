using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EF_Practices.Models;

namespace Model.Employees
{
    public class EmployeeInfo : ShopChild
    {
        [Required] [MaxLength(200)] public string Name { get; set; }

        [MaxLength(100)] public string Phone { get; set; }

        [MaxLength(50)] public string Email { get; set; }
        public string RoleId { get; set; }
        public double Salary { get; set; }
        public double SaleTargetAmount { get; set; }
        public double SaleAchivedAmount { get; set; }

        public string WarehouseId { get; set; }

        [ForeignKey("WarehouseId")] public virtual Warehouse Warehouse { get; set; }
    }
}