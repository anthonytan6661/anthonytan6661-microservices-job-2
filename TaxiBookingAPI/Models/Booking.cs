namespace TaxiBookingAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingTime { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public double Current_Location_Latitude { get; set; }
        public double Current_Location_Longitude { get; set; }

    }
}
