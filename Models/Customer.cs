using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EF_Practices.Models;
using Model.Sales;

namespace Model.Customers
{
    public class Customer : ShopChild
    {
        [Required] [MaxLength(100)] public string MembershipCardNo { get; set; }

        [MaxLength(100)] [Required] public string Name { get; set; }

        [Required] [MaxLength(100)] public string Phone { get; set; }

        [MaxLength(50)] public string Email { get; set; }
        [MaxLength(50)] public string NationalId { get; set; }
        [MaxLength(300)] public string ImageUrl { get; set; }
        [MaxLength(50)] public string Occupation { get; set; }

        [MaxLength(50)] public string University { get; set; }

        [MaxLength(50)] public string Company { get; set; }

        public int Point { get; set; }

        [MaxLength(100)] public string Remarks { get; set; }

        public int OrdersCount { get; set; }

        public double ProductAmount { get; set; }

        public double OtherAmount { get; set; }
        public double TotalDiscount { get; set; }

        public double TotalAmount { get; set; }

        public double TotalPaid { get; set; }

        public double TotalDue { get; set; }

        public int WcId { get; set; }

        public virtual ICollection<Sale> BuyingHistory { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

    }
}