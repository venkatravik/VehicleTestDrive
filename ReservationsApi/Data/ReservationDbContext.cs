using Microsoft.EntityFrameworkCore;
using ReservationsApi.Entity;

namespace ReservationsApi.Data
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options) { }
       
        public DbSet<Reservation> reservations { get; set; }

        public DbSet<Vehicle>vehicles { get; set; }
    }
}
