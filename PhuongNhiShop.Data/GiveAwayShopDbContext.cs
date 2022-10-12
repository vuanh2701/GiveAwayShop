
using ReuseShop.Model.Models;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace ReuseShop.Data
{
    public class ReuseShopDbContext : DbContext
    {
        public ReuseShopDbContext() : base("ReuseShop")
        {
            this.Configuration.LazyLoadingEnabled = false; // KHi load bàng cha thì không tự động include thêm bảng con
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        
        public DbSet<Consignment> Consignments { get; set; }
        public DbSet<ConsignmentCategory> ConsignmentCategories { get; set; }
        public DbSet<ConsignmentTag> ConsignmentTags { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
