namespace CustomersApi.Entity
{
    public class CustomeVehicle
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
