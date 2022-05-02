using EF_Practices.Models;
using Model.Sales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practices
{
    public class SaleState : ShopChild
    {
        [Required] [MaxLength(50)] public string State { get; set; }

        public string Remarks { get; set; }

        [Required] public string SaleId { get; set; }

        [ForeignKey("SaleId")] public virtual Sale Sale { get; set; }
    }
}