using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EF_Practices.Models;

namespace Model.Transactions
{
    public class Wallet : ShopChild
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        
        [MaxLength(100)]
        public string AccountNumber { get; set; }

        [MaxLength(50)]
        public string BankName { get; set; }

        [MaxLength(20)]
        public string CardNumber { get; set; }

        [MaxLength(20)]
        public string MobileNumber { get; set; }

        public double Balance { get; set; }

        public double StartingBalance { get; set; }

        [Required]
        public WalletType WalletType { get; set; }

        public string WarehouseId { get; set; }

        [ForeignKey("WarehouseId")]
        public virtual Warehouse Warehouse { get; set; }
    }
}