using CustomersApi.Entity;

namespace CustomersApi.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddCustomer(Customer customer);

        Task AddVehicle(Vehicle vehicle);

        Task<int> VehicleCount(int vehicleId);

      // Task CheckVehicle(Customer customer);
       // Task<int> CheckVehicle(int vehicleId);
    }
}
