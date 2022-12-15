using VehiclesApi.Entity;
using VehiclesApi.Models;

namespace VehiclesApi.Interfaces
{
    public interface IVehicleService
    {
        Task<List<VehicleDto>> GetAllVehicles();
        Task<VehicleDto> GetVehicleById(int id);
        Task AddVehicle(VehicleDto vehicle);
        Task DeleteVehicle(int id);
        Task UpdateVehicle(int id , VehicleDto vehicle);
    }
}
