using CPServerPart.PresentationLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CPServerPart.DataLayer
{
    public sealed class DataContext : DbContext
    {
        public static DataContext Instance;
        
        public DbSet<Product> Users { get; set; }
        
        public DataContext()
        {
            Database.EnsureCreated();
            Instance = this;
        }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=cpcd;Trusted_Connection=True;");
        }
    }
}