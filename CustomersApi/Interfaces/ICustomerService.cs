using CustomersApi.Models;

namespace CustomersApi.Interfaces
{
    public interface ICustomerService
    {
        Task AddCustomer(CustomerDto customer);
    }
}
