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

            string connectionString = "Endpoint=sb://vehicletrackingbus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=W6KvUevP6V+E8EtiTPeq03amLJp3ovyqTe/Ec6J/z2w=";
            string queueName = "CustomerInfo";

            var Custobj = JsonConvert.SerializeObject(entity);

            //var obj = JsonConverter.SerializeObject(entity);
            // since ServiceBusClient implements IAsyncDisposable we create it with "await using"
            await using var client = new ServiceBusClient(connectionString);

            // create the sender
            ServiceBusSender sender = client.CreateSender(queueName);

            // create a message that we can send. UTF-8 encoding is used when providing a string.
            ServiceBusMessage message = new ServiceBusMessage(Custobj);
            await sender.SendMessageAsync(message);
        }

    }
}
