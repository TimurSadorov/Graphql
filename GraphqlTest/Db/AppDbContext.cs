using GraphqlTest.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlTest.Db;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Order> Orders => Set<Order>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Product>()
            .HasMany(p => p.Orders)
            .WithMany(order => order.Products);
        
        modelBuilder
            .Entity<Order>()
            .HasMany(order => order.Products)
            .WithMany(p => p.Orders);
        
        base.OnModelCreating(modelBuilder);
    }
}