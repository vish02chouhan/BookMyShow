namespace BookMyShow.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Remember to handle securely
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }



}
