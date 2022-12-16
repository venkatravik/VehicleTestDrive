using Dapper.Contrib.Extensions;

namespace ReservationsApi.Entity
{
    public class Vehicle
    {
        [Key]
        public int vid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
