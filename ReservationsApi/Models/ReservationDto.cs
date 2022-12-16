namespace ReservationsApi.Models
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int VehicleId { get; set; }
        public VehicleDto vehicle { get; set; }
        public bool IsMailSent { get; set; }
    }
}
