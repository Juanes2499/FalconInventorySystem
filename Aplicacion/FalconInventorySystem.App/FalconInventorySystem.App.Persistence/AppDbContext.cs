using Microsoft.EntityFrameworkCore;
using FalconInventorySystem.App.Domain.Entities;


namespace FalconInventorySystem.App.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }
 
        public DbSet<Product> Products { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }

        public DbSet<BillOrder> BillOrders { get; set; }

        public DbSet<BillOrderItem> BillOrderItems { get; set; }

        public DbSet<ItemTransaction> ItemTransactions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder OptionBuilder)
        {
            if (!OptionBuilder.IsConfigured)
            {
                //OptionBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb; Initial Catalog=FalconInventorySystem;Integrated Security=True");
                OptionBuilder.UseSqlServer("data source=localhost,1433;initial catalog=FalconInventorySystem;persist security info=True;user id=sa;password=65F0r735cu3;MultipleActiveResultSets=True;App=EntityFramework");
            }
        }
    }
}
