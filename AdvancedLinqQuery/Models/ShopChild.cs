﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonLibrary.Model;
using Model.Shops;

namespace EF_Practices.Models
{
    public abstract class ShopChild : Entity
    {
        [Required] public string ShopId { get; set; }
        [ForeignKey("ShopId")] public virtual Shop Shop { get; set; }
    }
}