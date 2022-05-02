using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practices.Models
{
    public class ProductCategory : ShopChild
    {
        [Required]
        [MaxLength(100)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public int WcId { get; set; }

        [Required] public string ProductGroupId { get; set; }

        [ForeignKey("ProductGroupId")] public virtual ProductGroup ProductGroup { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}