namespace BookMyShow.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int ShowId { get; set; }
        public Show Show { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public decimal Price { get; set; }
    }



}
