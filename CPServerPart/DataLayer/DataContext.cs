using CPServerPart.PresentationLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CPServerPart.DataLayer
{
    public sealed class DataContext : DbContext
    {
        public static DataContext Instance;
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DailyReport> DailyReports { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        
        public DataContext()
        {
            Database.EnsureCreated();
            Instance = this;

            Products.Add(new Product());
            Checks.Add(new Check());
            Customers.Add(new Customer());
            Employees.Add(new Employee());
            DailyReports.Add(new DailyReport());
            ProductUnits.Add(new ProductUnit());
            Shops.Add(new Shop());

        }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
        }
    }
}