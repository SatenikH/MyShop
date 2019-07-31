using Microsoft.EntityFrameworkCore;

namespace EFMyShop.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SampleContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public SampleContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyShop;Trusted_Connection=True;");
        }
    }
}
