using VehiclesApi.Entity;

namespace VehiclesApi.Interfaces
{
    public interface IVehicleRepository
    {
        Task<List<Vehicle>> GetAllVehicles();
        Task<Vehicle> GetVehicleById(int id);
        Task AddVehicle(Vehicle vehicle);
        Task DeleteVehicle(int id);
        Task UpdateVehicle(Vehicle vehicle);
    }
}
