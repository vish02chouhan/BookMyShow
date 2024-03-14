namespace BookMyShow.Model
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public DateTime BookingTime { get; set; }
        public string Status { get; set; } // Suggested to use an enum
    }



}
