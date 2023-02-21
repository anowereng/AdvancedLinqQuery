using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonLibrary.Model;
using EF_Practices.Models;
using Microsoft.EntityFrameworkCore;
using Model.Brands;
using Model.Customers;
using Model.Sales;

namespace Model.Shops
{
    public class Shop : Entity
    {
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        [MaxLength(50)] public string Area { get; set; }

        [MaxLength(50)] public string Thana { get; set; }

        [MaxLength(50)] public string PostCode { get; set; }

        [MaxLength(50)] public string District { get; set; }

        [MaxLength(50)] public string Country { get; set; }


        [StringLength(50)]
        [DataType(DataType.Text)]
        public string ContactPersonName { get; set; }

        [StringLength(20)]
        [DataType(DataType.Text)]
        public string ContactPersonPhone { get; set; }

        [StringLength(50)]
        [DataType(DataType.Text)]
        public string ContactPersonDesignation { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(50)] public string Website { get; set; }

        [MaxLength(50)] public string Email { get; set; }

        [MaxLength(50)] public string Facebook { get; set; }

        public string Remarks { get; set; }

        [MaxLength(100)]
        [DataType(DataType.Text)]
        public string About { get; set; }

        [Required]       
        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        [Required]        
        [Column(TypeName = "datetime2")]
        public DateTime ExpiryDate { get; set; }

        public bool IsDeleted { get; set; }

        [MaxLength(50)] public string SubscriptionType { get; set; }

        public int TotalUsers { get; set; }

        public bool IsVerified { get; set; }

        public bool HasDeliveryChain { get; set; }

       [MaxLength(50)] public string WcUrl { get; set; }

       [MaxLength(50)] public string WcKey { get; set; }

       [MaxLength(50)] public string WcSecret { get; set; }

        public string WcVersion { get; set; }

       [MaxLength(100)] public string WcWebhookSource { get; set; }

        [MaxLength(200)] public string LogoUrl { get; set; }

        public bool IsShowOrderNumber { get; set; }

        public bool IsAutoAddToCart { get; set; }

        public float DeliveryCharge { get; set; }

        [MaxLength(50)] public string ReceiptName { get; set; }

        [MaxLength(50)] public string ChalanName { get; set; }


        // associated lists
        public virtual ICollection<Brand> Brands { get; set; }
        //public virtual ICollection<Address> Addresses { get; set; }
        //public virtual ICollection<Transaction> Transactions { get; set; }
        //public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        //public virtual ICollection<Purchase> Purchases { get; set; }
        //public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}