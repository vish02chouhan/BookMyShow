namespace BookMyShow.Model
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<CinemaHall> CinemaHalls { get; set; } = new List<CinemaHall>();
    }


}
