using app.Domain;
using Microsoft.EntityFrameworkCore;

public class AbartDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Inventory> Inventory { get; set; }

    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=abart;user=root;password=7FNwpGmU",
            ServerVersion.Parse("11.3-mariadb"));
    }
}