using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EF_Practices.Models;

namespace Model.Brands
{
    public class Brand : ShopChild
    {
       
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [MaxLength(50)] public string Phone { get; set; }

        [MaxLength(200)]
        [DataType(DataType.Text)]
        public string Remarks { get; set; }


        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string ContactPersonName { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string MadeInCountry { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [MaxLength(20)]
        [DataType(DataType.Text)]
        public string BrandCode { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}