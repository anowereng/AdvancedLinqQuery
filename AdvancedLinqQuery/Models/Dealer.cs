namespace Model.Dealers
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using EF_Practices.Models;
    using Model.Sales;

    public class Dealer : ShopChild
    {
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)] public string StreetAddress { get; set; }

        [MaxLength(50)] public string Area { get; set; }

        [MaxLength(50)] public string Thana { get; set; }

        [MaxLength(50)] public string PostCode { get; set; }

        [MaxLength(50)] public string District { get; set; }

        [MaxLength(50)] public string Country { get; set; }

        [MaxLength(50)] public string Phone { get; set; }

        [MaxLength(50)] public string Remarks { get; set; }

        [MaxLength(50)] public string CompanyName { get; set; }

        [MaxLength(100)]
        [DataType(DataType.Text)]
        public string ContactPersonName { get; set; }

        public bool IsVerified { get; set; }

        public int OrdersCount { get; set; }

        public double ProductAmount { get; set; }

        public double OtherAmount { get; set; }
        public double TotalDiscount { get; set; }

        public double TotalAmount { get; set; }

        public double TotalPaid { get; set; }

        public double TotalDue { get; set; }

        // associated list
        public virtual ICollection<Sale> Sales { get; set; }
    }
}