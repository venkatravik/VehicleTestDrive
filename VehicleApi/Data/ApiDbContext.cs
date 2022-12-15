using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VehiclesApi.Entity;

namespace VehiclesApi.Data
{
    public class ApiDbContext :DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { } 
       
         
       public DbSet<Vehicle> Vehicles { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=VehicleApiDb;Trusted_Connection=True;TrustServerCertificate=True");
        //}
    }
}
