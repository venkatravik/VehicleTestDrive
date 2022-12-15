using Microsoft.EntityFrameworkCore;
using VehiclesApi.Data;
using VehiclesApi.Interfaces;
using VehiclesApi.Entity;
using static Dapper.SqlMapper;

namespace VehiclesApi.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApiDbContext _dbContext;
       

        public VehicleRepository(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddVehicle(Vehicle vehicle)
        {
            await _dbContext.Vehicles.AddAsync(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteVehicle(int id)
        {
            var vehicle = await _dbContext.Vehicles.FindAsync(id);
            _dbContext.Vehicles.Remove(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Vehicle>> GetAllVehicles()
        {
            var vehicles = await _dbContext.Vehicles.ToListAsync();
            return vehicles;
        }

        public async Task<Vehicle> GetVehicleById(int id)
        {
            var vechile = await _dbContext.Vehicles.FindAsync(id);
            return vechile;
        }

        public async Task UpdateVehicle(Vehicle vehicle)
        {
            _dbContext.Attach(vehicle);
            var vechileobj =  _dbContext.Update(vehicle).Entity;
            await _dbContext.SaveChangesAsync();
        }
    }
}
