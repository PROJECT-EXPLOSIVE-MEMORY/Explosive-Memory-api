﻿using Explosive.Memory.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Explosive.Memory.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item> Items {get; set;}
    }
}
