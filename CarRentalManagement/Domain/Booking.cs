namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int vehicleId { get; set; }
        public int customerId { get; set; }

    }
}