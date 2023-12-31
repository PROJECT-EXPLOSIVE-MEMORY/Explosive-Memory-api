using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Explosive.Memory.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.UseSqlite("Data Source=../Registrar.sqlite",
    b => b.MigrationsAssembly("Explosive-Memory.Api"));

        return new StoreContext(optionsBuilder.Options);
    }
}