using CustomersApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace CustomersApi.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<Customer> customers { get; set; }
   
    }
}
