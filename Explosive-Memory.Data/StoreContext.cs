using Explosive.Memory.Domain.Catalog;
using Explosive.Memory.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Explosive.Memory.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item> Items {get; set;}
            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                DbInitializer.Initialize(builder);
            }

        public DbSet<Order> Orders {get; set;}
    }
}
