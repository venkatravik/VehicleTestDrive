using CustomersApi.Data;
using CustomersApi.Entity;
using CustomersApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomersApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _customerDbContext;

        public CustomerRepository(CustomerDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }

        public async Task AddCustomer(Customer customer)
        {
                await _customerDbContext.customers.AddAsync(customer);
                await _customerDbContext.SaveChangesAsync();
            
        }

        public async Task<int> VehicleCount(int vehicleId)
        {
            return await _customerDbContext.customers.CountAsync(c => c.VehicleId == vehicleId);
        
        }

        //public async Task<int> CheckVehicle(int vehicleId)
        //{

        //    var vehicleobj = await _customerDbContext.vehicles.FirstOrDefaultAsync(v => v.Id == customer.VehicleId);
        //    if (vehicleobj == null)
        //    {
        //           // await _customerDbContext.vehicles.AddAsync(customer.vehicle);
        //            await _customerDbContext.SaveChangesAsync();
        //    }
        //}

        public async Task AddVehicle(Vehicle vehicle)
        {
           await _customerDbContext.vehicles.AddAsync(vehicle);
            await _customerDbContext.SaveChangesAsync();
        }
    }
}
