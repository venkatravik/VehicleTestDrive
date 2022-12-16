using AutoMapper;
using Azure.Messaging.ServiceBus;
using CustomersApi.Entity;
using CustomersApi.Interfaces;
using CustomersApi.Models;
using Newtonsoft.Json;


namespace CustomersApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private IMapper _mapper;


        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task AddCustomer(CustomerDto customer)
        {

            var entity = _mapper.Map<Customer>(customer);
            await _customerRepository.AddCustomer(entity);

            string connectionString = "";
            
            string queueName = "CustomerInfo";

            var Custobj = JsonConvert.SerializeObject(entity);

            await using var client = new ServiceBusClient(connectionString);
            
            ServiceBusSender sender = client.CreateSender(queueName);

            ServiceBusMessage message = new ServiceBusMessage(Custobj);
            await sender.SendMessageAsync(message);
        }

    }
}
