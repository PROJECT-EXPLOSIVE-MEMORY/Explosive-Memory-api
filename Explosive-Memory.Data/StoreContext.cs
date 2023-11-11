using Explosive.Memory.Domain.Catalog;
using Explosive.Memory.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Explosive.Memory.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(){
            
        }
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item> Items {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source = ../Registrar.sqlite",
    b => b.MigrationsAssembly("Explosive-Memory.Api"));
        }
    }

        public DbSet<Order> Orders {get; set;}
            
    }
}
