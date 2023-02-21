using EF_Practices;
using EF_Practices.Models;
using Microsoft.EntityFrameworkCore;
using Model.Brands;
using Model.Customers;
using Model.Dealers;
using Model.Employees;
using Model.Sales;
using Model.Shops;
using Model.Transactions;
using System.Linq;

namespace EFGenericsAPI.dbContext
{
    public class BuisnessContext : DbContext
    {
        public BuisnessContext(DbContextOptions<BuisnessContext> options) : base(options) { }

        public  DbSet<Wallet> Wallets { get; set; }
        public  DbSet<Warehouse> Warehouses { get; set; }
        public  DbSet<Sale> Sales { get; set; }
        public  DbSet<SaleState> SaleStates { get; set; }
        public  DbSet<SaleDetail> SaleDetails { get; set; }
        public  DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public  DbSet<Transaction> Transactions { get; set; }
        public  DbSet<AccountHead> AccountHeads { get; set; }
        public  DbSet<Dealer> Dealers { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<ProductDetail> ProductDetails { get; set; }
        public  DbSet<Brand> Brands { get; set; }
        public  DbSet<ProductGroup> ProductGroups { get; set; }
        public  DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Address>().HasOne(e => e.Customer)
            //.WithMany(x => x.Addresses).Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}