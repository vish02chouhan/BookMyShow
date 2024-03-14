namespace BookMyShow.Model
{
    public class Show
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public CinemaHall CinemaHall { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }



}
