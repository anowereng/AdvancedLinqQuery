namespace Model.Transactions
{
    using EF_Practices.Models;
    using System.ComponentModel.DataAnnotations;

    public class AccountHead : ShopChild
    {
         [Required] [MaxLength(50)] public string Name { get; set; }

         [Required] public AccountHeadType AccountHeadType { get; set; }
    }
}