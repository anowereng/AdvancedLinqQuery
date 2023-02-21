
namespace Model.Transactions
{
    using EF_Practices.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Transaction : ShopChild
    {
        [Required]
        public TransactionFlowType TransactionFlowType { get; set; }

        [Required]
        public TransactionMedium TransactionMedium { get; set; }

        [Required]
        public PaymentGatewayService PaymentGatewayService { get; set; }

        [Required]
        public TransactionFor TransactionFor { get; set; }

        [Required]
        public TransactionWith TransactionWith { get; set; }

        [MaxLength(50)]
        public string ParentId { get; set; }

        [MaxLength(50)]
        public string ParentName { get; set; }

        [MaxLength(50)]
        public string OrderNumber { get; set; }

        [MaxLength(50)]
        public string OrderId { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public double Amount { get; set; }

        [MaxLength(50)]
        public string TransactionNumber { get; set; }

        [MaxLength(100)]
        public string Remarks { get; set; }

        [MaxLength(50)]
        public string ContactPersonName { get; set; }

        [MaxLength(50)]
        public string ContactPersonPhone { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TransactionDate { get; set; }

        [MaxLength(50)]
        [Required]
        public string AccountHeadName { get; set; }

        
        [Required]
        public string AccountHeadId { get; set; }

        [ForeignKey("AccountHeadId")]
        public virtual AccountHead AccountHead { get; set; }

        
        public string WalletId { get; set; }

        [ForeignKey("WalletId")]
        public virtual Wallet Wallet { get; set; }

        
        public string WarehouseId { get; set; }

        [ForeignKey("WarehouseId")]
        public virtual Warehouse Warehouse { get; set; }

        public TransactionState State { get; set; }
    }
}