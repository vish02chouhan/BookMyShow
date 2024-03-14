namespace BookMyShow.Model
{
    public class Seat
    {
        public int Id { get; set; }
        public int CinemaHallId { get; set; }
        public CinemaHall CinemaHall { get; set; }
        public string Number { get; set; }
        public char Row { get; set; }
        // Removed IsAvailable since availability can be determined by related tickets and show times
    }



}
