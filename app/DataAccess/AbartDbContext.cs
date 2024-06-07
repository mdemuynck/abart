using app.Domain;
using Microsoft.EntityFrameworkCore;

public class AbartDbContext : DbContext
{

    public IConfiguration Configuration { get; }
    public DbSet<Person> People { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    public AbartDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseMySql(connectionString,
            ServerVersion.Parse("11.3-mariadb"));
    }
}