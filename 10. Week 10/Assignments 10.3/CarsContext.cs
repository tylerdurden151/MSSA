using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3;

public class CarsContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=cars.db");
}